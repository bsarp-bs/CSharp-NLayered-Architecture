using BusinessLayer.Abstract_Services_;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete_Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    public class StaffController : Controller
    {
        IStaffService _staffService;

        public StaffController(IStaffService staffservice)
        {
            _staffService = staffservice;
        }

        public IActionResult StaffIndex()
        {
            var value = _staffService.GetAllS();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStaff(Staff s)
        {

            StaffValidation validation_rules = new StaffValidation();
            ValidationResult result = validation_rules.Validate(s);

            if (result.IsValid)
            {
                _staffService.InsertS(s);
                return RedirectToAction("StaffIndex");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }

        public IActionResult DeleteStaff(int id)
        {
            var value = _staffService.GetByIDS(id);
            _staffService.DeleteS(value);
            return RedirectToAction("StaffIndex");
        }

        [HttpGet]
        public IActionResult EditStaff(int id)
        {
           var value = _staffService.GetByIDS(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditStaff(Staff s)
        {
            _staffService.UpdateS(s);
            return RedirectToAction("StaffIndex");
        }
    }
}
