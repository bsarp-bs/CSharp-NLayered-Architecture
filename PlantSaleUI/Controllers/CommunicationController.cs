using BusinessLayer.Abstract_Services_;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete_Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    public class CommunicationController : Controller
    {
        private readonly ICommunicationService _communicationService;

        public CommunicationController(ICommunicationService commuservice)
        {
            _communicationService = commuservice;
        }

        public IActionResult CommunicationIndex()
        {
            return View(_communicationService.GetAllS());
        }

        [HttpGet]
        public IActionResult AddCommunication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCommunication(Communication c)
        {
            CommunicationValidation vv = new CommunicationValidation();
            ValidationResult results = vv.Validate(c);

            if (results.IsValid)
            {
                _communicationService.InsertS(c);
                return RedirectToAction("CommunicationIndex");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }

        public IActionResult DeleteCommunication(int id)
        {
            var value = _communicationService.GetByIDS(id);
            _communicationService.DeleteS(value);
            return RedirectToAction("CommunicationIndex");
        }

        [HttpGet]
        public IActionResult UpdateCommunication(int id)
        {
            var value = _communicationService.GetByIDS(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult UpdateCommunication(Communication c)
        {
            _communicationService.UpdateS(c);
            return RedirectToAction("CommunicationIndex");
        }
    }
}
