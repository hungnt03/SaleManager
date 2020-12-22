using OfficeOpenXml;
using OfficeOpenXml.Style;
using SaleManager.Models;
using SaleManager.Utils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            }).OrderBy(x => x.ProductName).ToList();
        }

        public void Export(List<BarcodeModel> barcodes)
        {
            var rowLen = 4;
            var colLen = 3;
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
            var currRow = 1;
            var currCol = 1;
            foreach (var elm in barcodes)
            {
                if (currCol > 7)
                {
                    currRow += rowLen;
                    currCol = 1;
                }

                var excelImage = worksheet.Drawings.AddPicture(elm.ProductName, elm.BarcodeImg);
                //add the image to row 20, column E
                excelImage.SetPosition(currRow - 1, 0, currCol - 1, 0);
                worksheet.Cells[currRow + rowLen - 2, currCol].Value = elm.ProductName;
                worksheet.Cells[currRow + rowLen - 2, currCol, currRow + rowLen - 2, currCol + 2].Merge = true;
                worksheet.Cells[currRow + rowLen - 2, currCol, currRow + rowLen - 2, currCol + 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                currCol += colLen;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Worksheets|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                excelPackage.SaveAs(fi);
                MessageUtil.Information("Tạo file thành công.");
            }
        }
    }
}
