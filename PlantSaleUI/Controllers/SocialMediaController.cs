using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    public class SocialMediaController : Controller
    {
        ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
