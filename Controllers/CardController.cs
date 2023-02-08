using Idcardmvc.Data;
using Idcardmvc.Models;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet]
        public IActionResult CardInformation()
        {

            return View();
        }
        //[HttpPost]
        //public IActionResult CardInformation(IdDetail detail)
        //{
        //    IdDetail idDetail= new IdDetail();

        //    if (ModelState.IsValid)
        //    {
        //        idDetail.Name = detail.Name;
        //        idDetail.Profession = detail.Profession;
        //        idDetail.CompanyName = detail.CompanyName;
        //        idDetail.ContactNumber = detail.ContactNumber;
        //        idDetail.Location = detail.Location;
        //        idDetail.Email= detail.Email;
        //        idDetail.Website= detail.Website;
                
        //        return View();
        //    }
        //    context.IdDetails.Add(idDetail);
        //    return View();
        //}
    }
}
