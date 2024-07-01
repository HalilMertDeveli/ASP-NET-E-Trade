using Microsoft.AspNetCore.Mvc;

namespace etrade_app.Controllers
{
    public class ForgotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
