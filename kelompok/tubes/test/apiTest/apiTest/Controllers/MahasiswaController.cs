using Microsoft.AspNetCore.Mvc;

namespace apiTest.Controllers
{
    public class MahasiswaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
