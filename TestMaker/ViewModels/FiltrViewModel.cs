using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMaker.ViewModels
{
    public class FiltrParams
    {
        public FiltrViewModel[] Params { get; set; }
    }
    public class FiltrViewModel
    {
        public string Text { get; set; }
        public int QuestionId { get; set; }
        public int TestId { get; set; }
        public int SamplePersonId { get; set; }
    }
}
