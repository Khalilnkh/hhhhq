﻿using Microsoft.AspNetCore.Mvc;

namespace WebTask.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
