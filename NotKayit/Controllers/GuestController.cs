using Microsoft.AspNetCore.Mvc;

namespace NotKayit.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
