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

namespace FuNewsManagement.Controllers
{
    public class SystemAccountsController : Controller
    {
        private readonly IAccountService _accountService;

        public SystemAccountsController(IAccountService context)
        {
            _accountService = context;
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
                var user = _accountService.GetSystemAccountByEmail(model.AccountEmail);


                if (user != null && user.AccountPassword == model.AccountPassword)
                {
                     //Store user information in session
                    HttpContext.Session.SetString("AccountId", user.AccountId.ToString());
                    HttpContext.Session.SetString("AccountRole", user.AccountRole.ToString());

                    return RedirectToAction("Index", "NewsArticles"); // Redirect to home page
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
