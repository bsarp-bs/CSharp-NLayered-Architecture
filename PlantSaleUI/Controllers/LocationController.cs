using BusinessLayer.Abstract_Services_;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    public class LocationController : Controller
    {
        ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public IActionResult LocIndex()
        {
            return View(_locationService.GetAllS());
        }

        [HttpGet]
        public IActionResult AddLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLocation(Location location)
        {
            _locationService.InsertS(location);
            return RedirectToAction("LocIndex");
        }

        public IActionResult DeleteLocation(int id)
        {
            var location = _locationService.GetByIDS(id);
            _locationService.DeleteS(location);
            return RedirectToAction("LocIndex");
        }

        [HttpGet]
        public IActionResult UpdateLocation(int id)
        {
            var location = _locationService.GetByIDS(id);
            return View(location);
        }

        [HttpPost]
        public IActionResult UpdateLocation(Location location)
        {
            _locationService.UpdateS(location);
            return RedirectToAction("LocIndex");
        }

    }
}
