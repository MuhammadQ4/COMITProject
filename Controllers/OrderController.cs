using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            
            return View();
        }
    }
}