using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    [Authorize (Roles ="Home")]
    public class HomeController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;

        public HomeController(UserManager<CustomIdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Users()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = _userManager.Users.Where(u=>u.Id!=user.Id).ToList();
            return View(users);
        }
        public IActionResult Settings()
        {
            return View();
        }        
        public IActionResult Stories()
        {
            return View();
        }
        public IActionResult Videos()
        {
            return View();
        }
        public IActionResult Badges()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }
        public IActionResult Chat()
        {
            return View();
        }
    }
}
