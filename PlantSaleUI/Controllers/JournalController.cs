using BusinessLayer.Abstract_Services_;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Mvc;

namespace PlantSaleUI.Controllers
{
    public class JournalController : Controller
    {
        IJournalService _journalService;

        public JournalController(IJournalService journalService)
        {
            _journalService = journalService;
        }

        public IActionResult JournalIndex()
        {
            var values = _journalService.GetAllS();
            return View(values);
        }

        public IActionResult DeleteJournal(int id)
        {
            var value = _journalService.GetByIDS(id);
            _journalService.DeleteS(value);
            return RedirectToAction("JournalIndex");
        }

        [HttpGet]
        public IActionResult AddJournal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJournal(Journal j)
        {
            _journalService.InsertS(j);
            return RedirectToAction("JournalIndex");
        }

        [HttpGet]

        public IActionResult UpdateJournal(int id)
        {
            var value = _journalService.GetByIDS(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateJournal(Journal j)
        {
            _journalService.UpdateS(j);
            return RedirectToAction("JournalIndex");
        }
    }
}
