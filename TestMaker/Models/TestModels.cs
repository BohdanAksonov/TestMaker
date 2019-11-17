using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestMaker.Models
{
    public class Test
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public virtual List<Question> Questions { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
        public string Password { get; set; }
    }

    public class Question
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int TestId { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public virtual List<AnswerChoice> AnswerChoices { get; set; }
    }

    public class Answer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int QuestionId { get; set; }
        public string Text { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }

    public class AnswerChoice
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int SamplePersonId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }
}
