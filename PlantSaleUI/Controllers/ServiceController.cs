using BusinessLayer.Abstract_Services_;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    public class ServiceController : Controller
    {
        IServiceService _service;

        public ServiceController(IServiceService service)
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
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service s)
        {
            _service.InsertS(s);
            return RedirectToAction("ServiceIndex");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _service.GetByIDS(id);
            _service.DeleteS(value);

            return RedirectToAction("ServiceIndex");

        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var value = _service.GetByIDS(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditService(Service s)
        {
            _service.UpdateS(s);
            return RedirectToAction("ServiceIndex");
        }
    }
}
