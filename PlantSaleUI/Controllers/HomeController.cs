using BusinessLayer.Abstract_Services_;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        ICommunicationService _communicationService;

        public HomeController(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        public IActionResult HomeIndex()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Communication c)
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _communicationService.InsertS(c);
            return RedirectToAction("HomeIndex", "Home");
        }
    }
}
