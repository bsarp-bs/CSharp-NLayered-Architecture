using BusinessLayer.Abstract_Services_;
using BusinessLayer.Concrete_Manager;
using DataAccessLayer.Concrete_DAL.EntityFramework;
using DataAccessLayer.DAL_Context;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Mvc;
using PlantSaleUI.Models;

namespace PlantSaleUI.ViewComponents
{
    public class _DashboradGrapP : ViewComponent
    {
        private readonly IStaffService c;

        public _DashboradGrapP(IStaffService c)
        {
            this.c = c;
        }

        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = c.GetAllS().Count(x => x.WorkType == "Bahçıvan");

            //ViewBag.v2 = c.GetAllS().Count(x => x.WorkType == "Aşçı");

            var data = c.GetAllS()
             .GroupBy(x => x.WorkType)
             .Select(g => new StaffWorkTypeCounter
              {
                  WorkType = g.Key,
                  counter = g.Count()
              })
              .ToList();

            return View(data);

        }
    }
}
