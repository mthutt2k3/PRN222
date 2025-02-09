using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;
using DataAccessObjects;
using Services;
using System.Configuration;

namespace FuNewsManagement.Controllers
{
    public class SystemAccountsController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IConfiguration _configuration;


        public SystemAccountsController(IAccountService context, IConfiguration configuration)
        {
            _accountService = context;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(SystemAccount model)
        {
            if (ModelState.IsValid)
            {
                var adminEmail = _configuration["AdminAccount:AccountEmail"];
                var adminPassword = _configuration["AdminAccount:AccountPassword"];
                var adminId = _configuration["AdminAccount:AccountID"];
                var adminRole = _configuration["AdminAccount:AccountRole"];
                if (adminEmail == model.AccountEmail && adminPassword == model.AccountPassword)
                {
                    //Store user information in session
                    HttpContext.Session.SetString("AccountId", adminId);
                    HttpContext.Session.SetString("AccountRole", adminRole);

                    return RedirectToAction("Index", "Categories");
                }


                var user = _accountService.GetSystemAccountByEmail(model.AccountEmail);

                if (user != null && user.AccountPassword == model.AccountPassword)
                {
                     //Store user information in session
                    HttpContext.Session.SetString("AccountId", user.AccountId.ToString());
                    HttpContext.Session.SetString("AccountRole", user.AccountRole.ToString());
                    if(user.AccountRole.Equals("1"))
                        return RedirectToAction("Index", "NewsArticles"); // Redirect to home page
                    else
                        return RedirectToAction("Index", "Tags");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }


            return View(model);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Clear session data
            return RedirectToAction("Login");
        }

    }
}
