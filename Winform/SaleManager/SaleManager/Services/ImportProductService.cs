using OfficeOpenXml;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SaleManager.Services
{
    public class ImportProductService : ServiceBase
    {
        public List<ImportProductModel> Read(string path)
        {
            var results = new List<ImportProductModel>();
            var inputFile = new ExcelPackage(new FileInfo(path));
            var sheet = inputFile.Workbook.Worksheets[1];
            var maxRow = sheet.Dimension.End.Row;
            var units = _db.Units.ToList();
            var suppliers = _db.Suppliers.ToList();
            for (var row = 2; row <= maxRow; row++)
            {
                if (sheet.Row(row) == null)
                    continue;
                var elm = new ImportProductModel()
                {
                    Barcode = sheet.Cells["A" + row].Value.ToString(),
                    ProductName = sheet.Cells["B" + row].Value.ToString(),
                    Total = int.Parse(sheet.Cells["C" + row].Value.ToString()),
                    Quantity = int.Parse(sheet.Cells["D" + row].Value.ToString()),
                    PriceBuy = int.Parse(sheet.Cells["E" + row].Value.ToString()),
                    Unit = units.Where(x => x.Name.Equals(sheet.Cells["F" + row].Value.ToString())).Select(x => x.Id).First(),
                    Price = int.Parse(sheet.Cells["G" + row].Value.ToString()),
                    Ex = DateTime.Parse(sheet.Cells["I" + row].Value.ToString()),
                    Supplier = suppliers.Where(x => x.Name.Equals(sheet.Cells["J" + row].Value.ToString())).Select(x => x.Id).First(),
                };
                results.Add(elm);
            }
            return results;
        }

        public List<UnitModel> GetUnits()
        {
            return _db.Units.Select(x => new UnitModel() { Id = x.Id, Name = x.Name }).ToList();
        }

        public List<KeyValue2> GetSuppliers()
        {
            return _db.Suppliers.Select(x => new KeyValue2() { key = x.Id, value = x.Name}).ToList();
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
            workSheet.Cells["H1"].Value = "Hsd(tháng)";
            workSheet.Cells["I1"].Value = "Hsd";
            workSheet.Cells["J1"].Value = "Nhà phân phối";
            //Format
            workSheet.Cells["A2"].Style.Numberformat.Format = "@";
            workSheet.Cells["C2"].Style.Numberformat.Format = "#,###";
            workSheet.Cells["D2"].Style.Numberformat.Format = "#";            
            workSheet.Cells["E2"].Style.Numberformat.Format = "#,###";
            workSheet.Cells["E2"].Formula = "ROUND(C2/D2,1)";
            workSheet.Cells["G2"].Style.Numberformat.Format = "#,###";
            workSheet.Cells["H2"].Style.Numberformat.Format = "#0.0";
            workSheet.Cells["I2"].Formula = "IF(H2<1, NOW()+30*H2, EDATE(NOW(),H2))";
            workSheet.Cells["I2"].Style.Numberformat.Format = "dd/mm/yyyy";
            var units = _db.Units.Select(x => x.Name).ToList();
            var unitValid = workSheet.DataValidations.AddListValidation("F2");
            foreach (var elm in units)
            {
                unitValid.Formula.Values.Add(elm);
            }
            var suppliers = _db.Suppliers.Select(x => x.Name).ToList();
            var supplierValid = workSheet.DataValidations.AddListValidation("J2");
            foreach (var elm in suppliers)
            {
                supplierValid.Formula.Values.Add(elm);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Worksheets|*.xlsx";
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
