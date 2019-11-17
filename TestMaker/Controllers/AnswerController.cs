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


namespace TestMaker.Controllers
{
    [Authorize(Roles = "Member")]
    public class AnswerController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppIdentityDbContext _dbContext;

        public AnswerController(UserManager<AppUser> userManager, AppIdentityDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult CreateNewAnswer(int id) => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewAnswer([FromBody]AnswerViewModel model)
        {
            Answer answer = new Answer()
            {
                Text = model.Text,
                QuestionId = model.QuestionId,
                Question = await _dbContext.Questions.FindAsync(model.QuestionId)
            };
            var testId = answer.Question.TestId;
            await _dbContext.Answers.AddAsync(answer);
            await _dbContext.SaveChangesAsync();
            return Json(Url.Action("Result", "Test", new { id = testId}));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnswer(int id, AnswerViewModel model)
        {
            var answerForDelete = await _dbContext.Answers.FindAsync(id);
            answerForDelete.Question = await _dbContext.Questions.FindAsync(answerForDelete.QuestionId);
            _dbContext.Answers.Remove(answerForDelete);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Result", "Test", new { id = answerForDelete.Question.TestId });
        }

    }
}
