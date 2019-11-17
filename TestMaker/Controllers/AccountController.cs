using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using TestMaker.Models;
using TestMaker.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace TestMaker.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public AccountController(SignInManager<AppUser> signInMng, UserManager<AppUser> userMng)
        {
            signInManager = signInMng;
            userManager = userMng;
        }

        [AllowAnonymous]
        public IActionResult Login() => View();

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                    return Json(Url.Action("Index", "Home"));
                else
                    return Json(false);
        }

        [AllowAnonymous]
        public IActionResult Register() => View();

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register ([FromBody] RegisterViewModel model)
        {

            var user = new AppUser
            {
                    UserName = model.Email,
                    Email = model.Email
            };

                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    //add a user to the default role
                    await userManager.AddToRoleAsync(user, "Member");
                    await signInManager.SignInAsync(user, false);
                    return Json(Url.Action("Index", "Home"));
                }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
