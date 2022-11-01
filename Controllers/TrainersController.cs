using Microsoft.AspNetCore.Mvc;

namespace WebTask.Controllers
{
    public class TrainersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
