using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TestMaker.Models;

namespace TestMaker.ViewModels
{
    public class TestViewModel
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public int Id { get; set; }

    }
}
