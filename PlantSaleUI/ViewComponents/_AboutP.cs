using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _AboutP : ViewComponent
    {
        IStaffService _staffService;

        public _AboutP(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_staffService.GetAllS());
        }


    }
}
