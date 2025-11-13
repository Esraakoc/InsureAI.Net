using Microsoft.AspNetCore.Mvc;

namespace InsurAI.NET.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
