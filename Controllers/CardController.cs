using Microsoft.AspNetCore.Mvc;

namespace Idcardmvc.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
