using OfficeOpenXml;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Utils;
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
                    Price = (sheet.Cells["G" + row].Value != null && StringUtil.IsNumberic(sheet.Cells["G" + row].Value.ToString())) ? int.Parse(sheet.Cells["G" + row].Value.ToString()) : 0,                    
                    Ex = DateTime.Parse(sheet.Cells["I" + row].Value.ToString()),
                    Supplier = suppliers.Where(x => x.Name.Equals(sheet.Cells["J" + row].Value.ToString())).Select(x => x.Id).First(),
                    Interest = (sheet.Cells["K" + row].Value != null && StringUtil.IsNumberic(sheet.Cells["K" + row].Value.ToString())) ? int.Parse(sheet.Cells["K" + row].Value.ToString()) : 0,
                };
                elm.Cal();
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
            workSheet.Cells["K1"].Value = "Tiền lãi";
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
            workSheet.Cells["K2"].Style.Numberformat.Format = "#,###";
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

        public void Save(List<ImportProductModel> datas)
        {
            var barcodes = datas.Select(x => new { Barcode = x.Barcode, Unit = x.Unit }).ToList();
            var products = _db.Products.Where(x=> barcodes.Any(b=>b.Barcode.Equals(x.Barcode) && b.Unit.Equals(x.Unit))).ToList();

            List<Product> adds = new List<Product>();
            List<Product> edits = new List<Product>();
            _db.Database.BeginTransaction();

            try
            {
                foreach (var elm in datas)
                {
                    var product = products.Where(x => x.Barcode.Equals(elm.Barcode) && x.Unit.Equals(elm.Unit)).FirstOrDefault();
                    // not exist
                    if (product == null)
                    {
                        var add = elm.ToProduct();
                        add.CreatedAt = DateTime.Now;
                        add.CreatedBy = "Administrator";
                        adds.Add(add);
                    }
                    else
                    {
                        var edit = elm.ToProduct(product);
                        _db.Products.Attach(edit);
                    }
                }

                _db.Products.AddRange(adds);
                //_db
                _db.Database.CurrentTransaction.Commit();
            }
            catch (Exception)
            {
                _db.Database.CurrentTransaction.Rollback();
                throw;
            }
        }
    }
}
