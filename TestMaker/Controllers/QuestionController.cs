using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMaker.Models;
using TestMaker.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft;
using Newtonsoft.Json;

namespace TestMaker.Controllers
{
    [Authorize(Roles = "Member")]
    public class QuestionController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppIdentityDbContext _dbContext;
        public QuestionController(UserManager<AppUser> userManager, AppIdentityDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult CreateMultipleChoice(int id) => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMultipleChoice([FromBody] QuestionViewModel model)
        {

            Question question = new Question()
            {
                Text = model.Text,
                TestId = model.TestId,
                Type = "Multiple"
            };

            await _dbContext.Questions.AddAsync(question);
            await _dbContext.SaveChangesAsync();
            string link = JsonConvert.SerializeObject(Url.Action("Result", "Test", new { id = model.TestId }));
            return Json(link);
            //return RedirectToAction("Result", "Test", new { id = model.TestId });
        }

        [HttpGet]
        public async Task<IActionResult> EditQuestion(int id)
        {
            var question = await _dbContext.Questions.FindAsync(id);

            QuestionViewModel model = new QuestionViewModel
            {
                Text = question.Text
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion([FromBody] QuestionViewModel model)
        {
            var questionForUpdate = await _dbContext.Questions.FindAsync(model.QuestionId);
            questionForUpdate.Text = model.Text;
            await _dbContext.SaveChangesAsync();
            return Json(Url.Action("Result", "Test", new { id = questionForUpdate.TestId }));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var questionForDelete = await _dbContext.Questions.FindAsync(id);
            _dbContext.Questions.Remove(questionForDelete);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Result", "Test", new { id = questionForDelete.TestId });
        }

        [HttpGet]
        public IActionResult CreateSingleAnswer(int id) => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSingleAnswer([FromBody] QuestionViewModel model)
        {
            Question question = new Question()
            {
                Text = model.Text,
                TestId = model.TestId,
                Type = "Single"
            };
            await _dbContext.Questions.AddAsync(question);
            await _dbContext.SaveChangesAsync();
            return Json(Url.Action("Result", "Test", new { id = model.TestId }));
        }

        [HttpGet]
        public IActionResult CreateShortAnswer(int id) => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShortAnswer([FromBody]QuestionViewModel model)
        {
            Question question = new Question()
            {
                Text = model.Text,
                TestId = model.TestId,
                Type = "Short"
            };
            await _dbContext.Questions.AddAsync(question);
            await _dbContext.SaveChangesAsync();
            return Json(Url.Action("Result", "Test", new { id = model.TestId }));
        }

        [HttpGet]
        public IActionResult CreateRangeQuestion(int id) => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRangeQuestion([FromBody]QuestionViewModel model)
        {
            Question question = new Question()
            {
                Text = model.Text,
                TestId = model.TestId,
                Type = "Range"
            };
            await _dbContext.Questions.AddAsync(question);
            await _dbContext.SaveChangesAsync();
            return Json(Url.Action("Result", "Test", new { id = model.TestId }));
        }


    }
}
