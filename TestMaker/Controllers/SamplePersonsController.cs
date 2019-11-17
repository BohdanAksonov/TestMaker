using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TestMaker.Models;
using TestMaker.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace TestMaker.Controllers
{
    [AllowAnonymous]
    [Route("[controller]/[action]")]
    public class SamplePersonsController : Controller
    {
        private readonly AppIdentityDbContext _dbContext;

        public SamplePersonsController(AppIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult GetTest()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetTest(int id, string password)
        {
            var accessPasword = _dbContext.Tests.Where(p => p.Id == id).Select(p=>p.Password).First();
            if (accessPasword == password)
            {
                IEnumerable<Question> questions = _dbContext.Questions.Where(p => p.TestId == id)
                       .Select(p => new Question
                       {
                           TestId = id,
                           Id = p.Id,
                           Text = p.Text,
                           Type = p.Type,
                           Answers = p.Answers.Select(c => new Answer
                           {
                               Id = c.Id,
                               Text = c.Text,
                               QuestionId = c.QuestionId
                           }).ToList()

                       }).ToList();
                return View("TestForSamplePersons", questions);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompleteTest([FromBody] List<AnswerChoiceViewModel> model)
        {
            Random random = new Random();
            int samplePersonId;
            do
            {
                samplePersonId = random.Next();
            }
            while (await _dbContext.AnswerChoices.AnyAsync(p => p.SamplePersonId == samplePersonId));
            int testId = model.First().TestId;
            var listOfQuestions = _dbContext.Questions.Where(p => p.TestId == testId).ToList();
            foreach (var answer in model)
            {
                if (answer.Type == "Multiple" || answer.Type=="Single")
                {
                    var result = await _dbContext.Answers.Where(p => p.Id == answer.AnswerId).Select(a => new AnswerChoice
                    {
                        QuestionId = a.QuestionId,
                        Text = a.Text,
                        SamplePersonId = samplePersonId,
                    }).FirstOrDefaultAsync();
                    await _dbContext.AnswerChoices.AddAsync(result);
                    if (answer.Type == "Multiple")
                    {
                        var questionForDelete = listOfQuestions.Find(p => p.Id == result.QuestionId);
                        if(questionForDelete != null)
                            listOfQuestions.Remove(listOfQuestions.Where(p => p.Id == result.QuestionId).First());
                    }
                    else
                        listOfQuestions.Remove(listOfQuestions.Where(p => p.Id == result.QuestionId).First());
                }
                else if(answer.Type=="Short" || answer.Type=="Range")
                {
                    var result = await _dbContext.Answers.Where(p => p.Id == answer.AnswerId).Select(a => new AnswerChoice
                    {
                        QuestionId = a.QuestionId,
                        SamplePersonId = samplePersonId,
                        Text = answer.Text
                    }).FirstOrDefaultAsync();
                    await _dbContext.AnswerChoices.AddAsync(result);
                    listOfQuestions.Remove(listOfQuestions.Where(p => p.Id == result.QuestionId).First());
                }

            }
            if (listOfQuestions.Count == 0)
            {
                await _dbContext.SaveChangesAsync();
                return Json(true);
            }
           return Json(false);
        }
    }
}
