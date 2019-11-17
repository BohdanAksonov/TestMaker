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
using System.Data;
using Newtonsoft.Json;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMaker.Controllers
{
    public class Filtr : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppIdentityDbContext _dbContext;
        public Filtr(UserManager<AppUser> userManager, AppIdentityDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult FiltrPage(int id)
        {
            List<Question> result = new List<Question>();
            result = _dbContext.Questions.Where(p=>p.TestId==id).ToList();
            foreach (var question in result)
            {
                question.Answers = _dbContext.Answers.Where(p=>p.QuestionId==question.Id).ToList();
            }
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetSamplePersonsId([FromBody] FiltrParams model)
        {
            var param = model.Params.ToList();
            List<int> idForSort = new List<int>();
            foreach (var item in param)
            {
                var result = await _dbContext.AnswerChoices.Where(p => p.QuestionId == item.QuestionId && p.Text == item.Text).Select(c => c.SamplePersonId).ToListAsync();
                foreach (var spId in result)
                    idForSort.Add(spId);
            }
            var returnId = idForSort.GroupBy(p => p).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            return Json(returnId);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetSamplePersonTest([FromBody]FiltrViewModel model)
        {
            //ResultViewModel result = new ResultViewModel
            //{
            //    Questions = await _dbContext.Questions.Where(p => p.TestId == model.TestId).ToListAsync(),
            //                //.Include(p => p.AnswerChoices).ToListAsync(),
            //    AnswerChoices = await _dbContext.AnswerChoices.Where(p=>p.SamplePersonId == model.SamplePersonId).ToListAsync()
            //};
            List<Question> result = new List<Question>();
            result = await _dbContext.Questions.Where(p => p.TestId == model.TestId).ToListAsync();
            foreach(var question in result)
            {
                question.AnswerChoices = await _dbContext.AnswerChoices.Where(p => p.SamplePersonId == model.SamplePersonId).ToListAsync();
            }
            return PartialView("LookTests",result);
            //return Json(RedirectToAction("LookTests", "Filtr", new { model = result }));
        }
        public IActionResult LookTests(List<Question> model)
        {
            return View(model);
        }
    }
}
