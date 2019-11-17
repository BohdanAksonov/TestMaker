using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMaker.Models;

namespace TestMaker.ViewModels
{
    public class ResultViewModel
    {
        public IEnumerable<Test> Tests { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public IEnumerable<AnswerChoice> AnswerChoices { get; set; }
    }
}
