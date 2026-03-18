using ClosedXML.Excel;
using DataAccessLayer.DAL_Context;
using Microsoft.AspNetCore.Mvc;
using PlantSaleUI.Models;
using System.Diagnostics;

namespace PlantSaleUI.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult ExcelIndex()
        {
            return View();
        }

        public List<ExcelModel> ExcelModel()
        {
            List<ExcelModel> excelModels = new List<ExcelModel>();
            using (Context c = new Context())
            {
                excelModels = c.Communications.Select(x => new ExcelModel
                {
                    ID = x.CommunicationID,
                    Name = x.Name,
                    Mail = x.Mail,
                    Message = x.Comment,
                    Date = x.Date
                }).ToList();
            }


            return excelModels;
        }

        public List<JournalExcelModel> ExcelModel2()
        {
            List<JournalExcelModel> excelmodel = new List<JournalExcelModel>();
            using (Context c = new Context())
            { 
                excelmodel = c.Journals.Select(x=> new JournalExcelModel
                {
                    ID = x.JournalID,
                    Title = x.Title,
                    Desc = x.Desc,
                    Date = x.Date,
                    Status = x.Status
                }).ToList();
            }

            return excelmodel;
        }

        public IActionResult ComReport()
        {
            using (var workB = new XLWorkbook()) 
            {
                var workSheet = workB.Worksheets.Add("İletişim Raporu");
                workSheet.Cell(1, 1).Value = "ID";
                workSheet.Cell(1, 2).Value = "Mesaj Gönderen";
                workSheet.Cell(1, 3).Value = "Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int rowCount = 2;

                foreach (var item in ExcelModel())
                {
                    workSheet.Cell(rowCount, 1).Value = item.ID;
                    workSheet.Cell(rowCount, 2).Value = item.Name;
                    workSheet.Cell(rowCount, 3).Value = item.Mail;
                    workSheet.Cell(rowCount, 4).Value = item.Message;
                    workSheet.Cell(rowCount, 5).Value = item.Date;
                    rowCount++;
                }

                using (var ss = new MemoryStream()) 
                {
                    workB.SaveAs(ss);
                    var contt = ss.ToArray();
                    return File(contt,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","IletisimRaporu.xlsx");
                }
            }

        }

        public IActionResult JourReport() 
        {

            using (var workB = new XLWorkbook())
            {
                var workSheet = workB.Worksheets.Add("Duyuru Raporu");
                workSheet.Cell(1, 1).Value = "ID";
                workSheet.Cell(1, 2).Value = "Başlık";
                workSheet.Cell(1, 3).Value = "Açıklama";
                workSheet.Cell(1, 4).Value = "Tarih";
                int rowCount = 2;
                foreach (var item in ExcelModel2())
                {
                    workSheet.Cell(rowCount, 1).Value = item.ID;
                    workSheet.Cell(rowCount, 2).Value = item.Title;
                    workSheet.Cell(rowCount, 3).Value = item.Desc;
                    workSheet.Cell(rowCount, 4).Value = item.Date;
                    rowCount++;
                }
                using (var ss = new MemoryStream())
                {
                    workB.SaveAs(ss);
                    var contt = ss.ToArray();
                    return File(contt, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DuyuruRaporu.xlsx");
                }
            }
        }
    }
}
