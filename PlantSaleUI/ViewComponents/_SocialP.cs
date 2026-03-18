using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _SocialP : ViewComponent
    {
        ISocialMediaService _mediaService;

        public _SocialP(ISocialMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _mediaService.GetAllS();
            return View(value);
        }
    }
}
