using Microsoft.AspNetCore.Mvc;

namespace NTierCalisma1.WEBUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
