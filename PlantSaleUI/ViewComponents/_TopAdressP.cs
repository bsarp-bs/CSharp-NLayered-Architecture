using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _TopAdressP : ViewComponent
    {

        ILocationService _locationService;

        public _TopAdressP(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _locationService.GetAllS();
            return View(value);
        }   
    }
}
