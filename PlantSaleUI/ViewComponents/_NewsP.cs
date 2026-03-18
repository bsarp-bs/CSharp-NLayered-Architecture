using BusinessLayer.Abstract_Services_;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.ViewComponents
{
    public class _NewsP : ViewComponent
    {
        IJournalService _journalService;

        public _NewsP(IJournalService journalService)
        {
            _journalService = journalService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_journalService.GetAllS());
        }
    }
}
