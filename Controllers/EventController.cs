﻿using Microsoft.AspNetCore.Mvc;

namespace WebTask.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
