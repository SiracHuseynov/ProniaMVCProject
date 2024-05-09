using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ProniaMVCProject.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
