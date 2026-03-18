using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _HeadP : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }   
}
