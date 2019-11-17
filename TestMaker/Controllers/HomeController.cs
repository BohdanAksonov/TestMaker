using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using TestMaker.Models;
using Newtonsoft.Json;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMaker.Controllers
{
    //[Route("[controller]/[action]")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppIdentityDbContext _dbContext;

        public HomeController(UserManager<AppUser> userManager, AppIdentityDbContext appIdentityDbContext)
        {
            _userManager = userManager;
            _dbContext = appIdentityDbContext;
        }
        public IActionResult Index()
        {
            List<Test> listOfTests = _dbContext.Tests.Where(p => p.UserId == _userManager.GetUserId(HttpContext.User)).ToList();
            return View(listOfTests);
        }
    }
}
