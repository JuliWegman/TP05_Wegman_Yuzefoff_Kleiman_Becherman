﻿using Microsoft.AspNetCore.Mvc;

namespace Tp05.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
