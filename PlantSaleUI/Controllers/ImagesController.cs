using BusinessLayer.Abstract_Services_;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using FluentValidation.Results;

namespace PlantSaleUI.Controllers
{
    public class ImagesController : Controller
    {
        IImagesService _imagesService;

        public ImagesController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }

        public IActionResult ImageIndex()
        {
            
            return View(_imagesService.GetAllS());
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Images ımages)
        {
            ImageValidation iM = new ImageValidation();
            ValidationResult result = iM.Validate(ımages);

            if (result.IsValid)
            {
                _imagesService.InsertS(ımages);
                return RedirectToAction("ImageIndex");
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

        public IActionResult DeleteImage(int id)
        {
            var values = _imagesService.GetByIDS(id);
            _imagesService.DeleteS(values);
            return RedirectToAction("ImageIndex");
        }

        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var values = _imagesService.GetByIDS(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateImage(Images ımages)
        {
            _imagesService.UpdateS(ımages);
            return RedirectToAction("ImageIndex");
        }
    }
}
