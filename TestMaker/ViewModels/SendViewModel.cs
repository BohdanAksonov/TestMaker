using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMaker.ViewModels
{
    public class SendParams
    {
        public SendViewModel[] Params { get; set; }
        public int TestId { get; set; }
    }

    public class SendViewModel
    {
        public string Address { get; set; }
       // public int TestId { get; set; }
    }
}
