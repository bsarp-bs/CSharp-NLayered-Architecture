using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _ServicesP : ViewComponent
    {
        IServiceService _services;

        public _ServicesP(IServiceService services)
        {
            _services = services;
        }

        public IViewComponentResult Invoke()
        {
            return View(_services.GetAllS());
        }
    }
}
