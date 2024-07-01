using Microsoft.AspNetCore.Mvc;

namespace etrade_app.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
