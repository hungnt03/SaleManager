using OfficeOpenXml;
using SaleManager.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SaleManager.Services
{
    public class BarcodeService : ServiceBase
    {
        public List<BarcodeModel> GetAll()
        {
            return _db.Products.Select(x => new BarcodeModel()
            {
                Barcode = x.Barcode,
                ProductName = x.Name
            }).OrderBy(x=>x.ProductName).ToList();
        }

        public void Export(List<BarcodeModel> barcodes)
        {
            var barcodeAlias = new Dictionary<string, List<string>>();
            barcodeAlias.Add("A", new List<string>() { "A", "a","", "Ă", "ă", "Â", "â" });
            barcodeAlias.Add("A", new List<string>() { "B", "b" });
            ExcelPackage excelPackage = new ExcelPackage();
            //for (char sheetName = 'A'; sheetName < 'Z'; sheetName++)
            //{
            //    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName.ToString());

            //}
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
            var excelImage = worksheet.Drawings.AddPicture("My Logo", barcodes[0].BarcodeImg);
            //add the image to row 20, column E
            excelImage.SetPosition(0, 0, 0, 0);
            FileInfo fi = new FileInfo(@"C:\磁気媒体EXP\File.xlsx");
            excelPackage.SaveAs(fi);
        }
    }
}
