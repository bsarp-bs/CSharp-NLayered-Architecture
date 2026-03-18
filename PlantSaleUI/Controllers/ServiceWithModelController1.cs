using BusinessLayer.Abstract_Services_;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Mvc;
using PlantSaleUI.Models;
using System.Reflection;

// Bu sayfa ise service insert akışını model kullanarak yapıyor. Program içerisinde kullanılmayacak örnek olması için yazıldı

namespace PlantSaleUI.Controllers
{
    public class ServiceWithModelController1 : Controller
    {
        IServiceService _service;

        public ServiceWithModelController1(IServiceService service)
        {
            this._service = service;
        }

        public IActionResult ServiceIndex()
        {
            var value = _service.GetAllS();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceInsertModel());
        }

        [HttpPost]
        public IActionResult AddService(ServiceInsertModel model)
        {

            if (ModelState.IsValid) 
            {
                 _service.InsertS(new Service()
                 {
                     Title = model.Title,
                     Desc = model.Desc,
                     Img = model.Image
                 });

                return RedirectToAction("ServiceIndex");
            }

            return View(model);

        }

    }

}
