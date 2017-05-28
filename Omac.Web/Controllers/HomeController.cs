using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omack.Services.ServiceImplementations;

namespace Omac.Web.Controllers
{
    public class HomeController : Controller
    {
        private ItemService _itemService;

        public HomeController(ItemService itemService) //Dependecy Injection via constructor
        {
            _itemService = itemService;
        }
        public IActionResult Index()
        {
            var items = _itemService.GetAll();
            return Ok(items); //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
