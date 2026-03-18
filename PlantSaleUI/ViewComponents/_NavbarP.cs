using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _NavbarP : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
