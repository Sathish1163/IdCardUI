using Idcardmvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace Idcardmvc.Controllers
{
    public class CardController : Controller
    {
        private readonly IDCContext context;

        public CardController(IDCContext _context)
        {
            context = _context;
        }
    
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult cardInformation()
        {

            return View();
        }

        public IActionResult Choosedesign()
        {
            return View();
        }

        public IActionResult Reviewcardinfo()
        {
            return View();
        } 
        
        public IActionResult Printpreview()
        {
            return View();
        }
        

    }
}
