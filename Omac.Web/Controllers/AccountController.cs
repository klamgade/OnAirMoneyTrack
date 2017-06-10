using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omack.Data.Infrastructure;
using Omack.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Omack.Web.Controllers
{
    public class AccountController : Controller
    {
        private UnitOfWork _unitOfWork;
        private UserManager<User> _userManager;

        public AccountController(UnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register(string returnUrl)
        {
            //do user registration
            if(await _userManager.FindByEmailAsync("bhupin@gmail.com") == null)
            {
                var user = new User()
                {
                    UserName = "Bhupin",
                    Email = "bhupin@gmail.com",
                    MediaId = 1
                };
                await _userManager.CreateAsync(user, "P@ssw0rd!");
                return Ok(user);
            }
            return View(); //return View();
        }
    }
}