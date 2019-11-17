using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMaker.Models;
using System.ComponentModel.DataAnnotations;


namespace TestMaker.ViewModels
{
    public class QuestionViewModel
    {
        [Required]
        public string Text { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
    }
}
