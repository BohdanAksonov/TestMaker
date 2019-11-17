using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMaker.ViewModels;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity;
using TestMaker.Models;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMaker.Controllers
{
    public class EmailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppIdentityDbContext _dbContext;
        public IConfiguration Configuration { get; set; }

        public EmailController(UserManager<AppUser> userManager, AppIdentityDbContext dbContext, IConfiguration configuration)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            Configuration = configuration;
        }
        // GET: /<controller>/
        public IActionResult Send()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendAsync([FromBody] SendParams model)
        {
            var messagesToSend = model.Params.ToList();
            var password = _dbContext.Tests.Where(p => p.Id == model.TestId).Select(p=>p.Password).First();
            using (var messages = new MailMessage())
            {
                foreach(var email in messagesToSend)
                {
                    messages.To.Add(new MailAddress(email.Address));
                    messages.From = new MailAddress("testmakersmtp@gmail.com");
                    messages.Subject = $"Test id and access password.";
                    messages.Body = $"This is link to your test: https://localhost:44396/SamplePersons/GetTest   Id:   {model.TestId}   Access password:   {password}";
                    messages.IsBodyHtml = true;
                    using (var client = new SmtpClient("smtp.gmail.com"))
                    {
                        client.Port = 587;
                        client.Credentials = new NetworkCredential(Configuration.GetSection("EmailCredential")["Email"], Configuration.GetSection("EmailCredential")["Password"]);
                        client.EnableSsl = true;
                        await client.SendMailAsync(messages);
                    }
                }
            }
            return Json(true);
        }
    }
}
