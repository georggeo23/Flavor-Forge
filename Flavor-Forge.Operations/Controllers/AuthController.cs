﻿using Microsoft.AspNetCore.Mvc;

namespace Flavor_Forge.Operations.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
