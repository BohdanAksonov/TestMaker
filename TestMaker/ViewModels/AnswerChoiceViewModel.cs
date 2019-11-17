using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMaker.ViewModels
{
    [Serializable]
    public class AnswerChoiceViewModel
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int TestId { get; set; }
    }
}
