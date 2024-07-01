using Microsoft.AspNetCore.Mvc;

namespace etrade_app.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
