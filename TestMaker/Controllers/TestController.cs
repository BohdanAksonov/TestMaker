using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMaker.Models;
using TestMaker.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Data;
using Newtonsoft.Json;

namespace TestMaker.Controllers
{
    [Authorize(Roles = "Member")]
    public class TestController : Controller
    {

        private const string XlsxContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        private readonly UserManager<AppUser> _userManager;
        private readonly AppIdentityDbContext _dbContext;

        public TestController(UserManager<AppUser> userManager, AppIdentityDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public static string GenerateRandomPassword(PasswordOptions opts = null)
        {
            if (opts == null) opts = new PasswordOptions()
            {
                RequiredLength = 12,
                RequiredUniqueChars = 5,
                RequireDigit = true,
                RequireLowercase = true,
                RequireNonAlphanumeric = true,
                RequireUppercase = true
            };

            string[] randomChars = new[] 
            {
                "ABCDEFGHJKLMNOPQRSTUVWXYZ",     
                "abcdefghijkmnopqrstuvwxyz",    
                "0123456789",                   
                "!@$?_-^%*"                        
            };
            Random rand = new Random(Environment.TickCount);
            List<char> chars = new List<char>();

            if (opts.RequireUppercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[0][rand.Next(0, randomChars[0].Length)]);

            if (opts.RequireLowercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[1][rand.Next(0, randomChars[1].Length)]);

            if (opts.RequireDigit)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[2][rand.Next(0, randomChars[2].Length)]);

            if (opts.RequireNonAlphanumeric)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[3][rand.Next(0, randomChars[3].Length)]);

            for (int i = chars.Count; i < opts.RequiredLength
                || chars.Distinct().Count() < opts.RequiredUniqueChars; i++)
            {
                string rcs = randomChars[rand.Next(0, randomChars.Length)];
                chars.Insert(rand.Next(0, chars.Count),
                    rcs[rand.Next(0, rcs.Length)]);
            }

            return new string(chars.ToArray());
        }

        [HttpGet]
        public async Task<IActionResult> GetTest()
        {

            List<Test> testList = new List<Test>();
            var userId = _userManager.GetUserId(HttpContext.User).ToString();
            var test = await _dbContext.Tests.FromSql($"exec get_tests {userId}").ToListAsync();
            return View(test);
        }

        [HttpGet]
        public IActionResult CreateTest()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTest(TestViewModel model)
        {
            var userId = await _userManager.GetUserAsync(HttpContext.User);
            var test = new Test()
            {
                Title = model.Title,
                Description = model.Description,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
                UserId = userId.Id,
                Password = GenerateRandomPassword()
                
            };
            await _dbContext.Tests.AddAsync(test);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> DeleteTest(int id)
        {
            var testForRemove = await _dbContext.Tests.FindAsync(id);
            _dbContext.Tests.Remove(testForRemove);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditTest(int id)
        {
            TestViewModel model = new TestViewModel();
            var test = _dbContext.Tests.Find(id);
            model.Title = test.Title;
            model.Description = test.Description;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTest(TestViewModel model)
        {
            if(ModelState.IsValid)
            {
                var testForUpdate = await _dbContext.Tests.FindAsync(model.Id);
                testForUpdate.Title = model.Title;
                testForUpdate.Description = model.Description;
                testForUpdate.LastModifiedDate = DateTime.Now;
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Result(int id)
        {
            ResultViewModel model = new ResultViewModel
            {
                Tests = _dbContext.Tests.Where(p => p.Id == id),
                Questions = _dbContext.Questions.Where(p => p.TestId == id)
                .Include(p => p.Answers).ToList()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult CompleteTests(int id)
        {
            try
            {
                ResultViewModel model = new ResultViewModel
                {
                    Questions = _dbContext.Questions.Where(p => p.TestId == id)
                .Include(p => p.AnswerChoices).ToList()
                };
                model.AnswerChoices = model.Questions.Select(p => p.AnswerChoices).First();
                return View(model);
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Export(int id)
        {
            ResultViewModel model = new ResultViewModel
            {
                Tests = _dbContext.Tests.Where(p => p.Id == id).ToList(),
                Questions = _dbContext.Questions.Where(p => p.TestId == id)
                    .Include(p => p.AnswerChoices).ToList()
            };
            model.AnswerChoices = model.Questions.Select(p => p.AnswerChoices).First();
            var test = model.Tests.First();
            DataTable table = new DataTable($"Test: {test.Title}");
            table.Columns.Add("Sample person ID", typeof(int));
            table.Columns.Add("Questions", typeof(string));
            table.Columns.Add("Answers", typeof(string));
            var listOfSPId = model.AnswerChoices.Select(p=>p.SamplePersonId).Distinct();
            foreach(var samplePerson in listOfSPId)
            {
                foreach (var question in model.Questions)
                {
                    foreach (var answer in question.AnswerChoices)
                    {
                        if (answer.SamplePersonId == samplePerson)
                        {
                            var row = table.NewRow();
                            row["Sample person ID"] = answer.SamplePersonId;
                            row["Questions"] = question.Text;
                            row["Answers"] = answer.Text;
                            table.Rows.Add(row);

                        }
                    }
                }
            }
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add($"Test:{test.Id}");
                worksheet.Cells[1, 3].Merge = true;
                worksheet.Cells[1, 1].Value = $"{test.Title}";
                worksheet.Cells["A2"].LoadFromDataTable(table, PrintHeaders: true);
                for(int i = 1; i < table.Columns.Count + 1; i++)
                {
                    worksheet.Column(i).AutoFit();
                }
                return File(package.GetAsByteArray(), XlsxContentType, "Report.xlsx");
            }
        }
        [HttpGet]
        public IActionResult Graphs()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetTestComboBox()
        {
            ResultViewModel model = new ResultViewModel
            {
                Tests = _dbContext.Tests.ToList()
            };
            List<string> testTitle = new List<string>();
            foreach (var item in model.Tests)
            {
                testTitle.Add(item.Title);
            }
            return Json(testTitle);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetQuestionComboBox([FromBody] string selectedTest)
        {
            var testId = _dbContext.Tests.Where(p => p.Title == selectedTest).Select(p => p.Id).First();
            ResultViewModel model = new ResultViewModel
            {
                Questions = _dbContext.Questions.Where(p => p.TestId == testId).ToList()
            };
            List<string> questionTitle = new List<string>();
            foreach(var question in model.Questions)
            {
                questionTitle.Add(question.Text);
            }
            return Json(questionTitle);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetAnswerChoices([FromBody] string selectedQuestion)
        {
            var questionId = _dbContext.Questions.Where(p => p.Text == selectedQuestion).Select(p=>p.Id).First();
            ResultViewModel model = new ResultViewModel
            {
                AnswerChoices = _dbContext.AnswerChoices.Where(p => p.QuestionId == questionId).ToList()
            };
            List<string> listOfQuestionsTitle = new List<string>();
            foreach (var item in model.AnswerChoices)
                listOfQuestionsTitle.Add(item.Text);
            var groups = listOfQuestionsTitle.GroupBy(p => p);
            List<ChartViewModel> result = new List<ChartViewModel>();
            foreach(var pare in groups)
            {
                ChartViewModel model2send = new ChartViewModel
                {
                    Value = pare.Key,
                    Count = pare.Count()
                };
                result.Add(model2send);
            }
            return Json(result);
        }
    }
}
