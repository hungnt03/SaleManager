using OfficeOpenXml;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.Services
{
    public class ImportProductService:ServiceBase
    {
        public List<ImportProductModel> Read(string path)
        {
            var results = new List<ImportProductModel>();
            var inputFile = new ExcelPackage(new FileInfo(path));
            var sheet = inputFile.Workbook.Worksheets[1];
            var maxRow = sheet.Dimension.End.Row;
            var units = _db.Units.ToList();
            for (var row = 2; row <= maxRow; row++)
            {
                if (sheet.Row(row) == null)
                    continue;
                var elm = new ImportProductModel()
                {
                    Barcode = sheet.Cells["A" + row].ToString(),
                    ProductName = sheet.Cells["B" + row].ToString(),
                    Total = int.Parse(sheet.Cells["C" + row].ToString()),
                    Quantity = int.Parse(sheet.Cells["D" + row].ToString()),
                    PriceBuy = int.Parse(sheet.Cells["E" + row].ToString()),
                    Unit = units.Where(x => x.Name.Equals(sheet.Cells["F" + row].ToString())).Select(x => x.Id).First(),
                    Price = int.Parse(sheet.Cells["G" + row].ToString()),
                    Ex = !string.IsNullOrEmpty(sheet.Cells["H" + row].ToString()) ? DateTime.Parse(sheet.Cells["H" + row].ToString()):DateTime.Now.AddYears(10)
                };
                results.Add(elm);
            }
            return results;
        }

        public List<UnitModel> GetUnits()
        {
            return _db.Units.Select(x => new UnitModel() { Id = x.Id, Name = x.Name }).ToList();
        }

        public void CreateTemplate()
        {
            

            var excelPackage = new ExcelPackage();
            // Tạo author cho file Excel
            excelPackage.Workbook.Properties.Author = "Hanker";
            // Tạo title cho file Excel
            excelPackage.Workbook.Properties.Title = "EPP test background";
            // thêm tí comments vào làm màu 
            excelPackage.Workbook.Properties.Comments = "This is my fucking generated Comments";
            // Add Sheet vào file Excel
            excelPackage.Workbook.Worksheets.Add("First Sheet");
            // Lấy Sheet bạn vừa mới tạo ra để thao tác 
            var workSheet = excelPackage.Workbook.Worksheets[1];
            // Header
            workSheet.Cells["A1"].Value = "Barcode";
            workSheet.Cells["B1"].Value = "Tên sản phẩm";
            workSheet.Cells["C1"].Value = "Thành tiền";
            workSheet.Cells["D1"].Value = "Số lượng";
            workSheet.Cells["E1"].Value = "Giá mua";
            workSheet.Cells["F1"].Value = "Đơn vị";
            workSheet.Cells["G1"].Value = "Giá bán";
            workSheet.Cells["H1"].Value = "Hsd";
            workSheet.Cells["I1"].Value = "Nhà phân phối";
            //Format
            workSheet.Cells["C2"].Style.Numberformat.Format = "$#,###";
            workSheet.Cells["E2"].Style.Numberformat.Format = "$#,###";
            workSheet.Cells["G2"].Style.Numberformat.Format = "$#,###";
            workSheet.Cells["E2"].Formula = "ROUND(C2/D2,1)";
            var units = _db.Units.Select(x => x.Name).ToList();
            var unitValid = workSheet.DataValidations.AddListValidation("F1");
            foreach(var elm in units)
            {
                unitValid.Formula.Values.Add(elm);
            }
            var suppliers = _db.Suppliers.Select(x => x.Name).ToList();
            var supplierValid = workSheet.DataValidations.AddListValidation("I1");
            foreach (var elm in suppliers)
            {
                supplierValid.Formula.Values.Add(elm);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Worksheets|*.xls";
            string expPath = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                expPath = saveFileDialog.FileName;
            }
            var file = new FileInfo(expPath);
            excelPackage.SaveAs(file);
        }
    }
}
