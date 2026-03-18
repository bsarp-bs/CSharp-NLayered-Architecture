using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;
using PlantSaleUI.Models;

namespace PlantSaleUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashboardIndex()
        {
            return View();
        }
    }
}
