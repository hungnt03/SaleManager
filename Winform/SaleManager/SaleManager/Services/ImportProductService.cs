using OfficeOpenXml;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Utils;
using SaleManager.Views;
using SaleManager.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
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
            var units = _db.Units.Select(x => new KeyValueInt() { Key = x.Id, Value = x.Name }).ToList();
            var suppliers = _db.Suppliers.Select(x => new KeyValueInt() { Key = x.Id, Value = x.Name }).ToList();
            var products = _db.Products.ToList();
            for (var row = 2; row <= maxRow; row++)
            {
                if (sheet.Row(row) == null)
                    continue;
                var elm = new ImportProductModel()
                {
                    Barcode = sheet.Cells["A" + row].Value.ToString(),
                    ProductName = sheet.Cells["B" + row].Value.ToString(),
                    Total = sheet.Cells["C" + row].Value.ToString().IsNumberic() ? int.Parse(sheet.Cells["C" + row].Value.ToString()) : 0,
                    Quantity = sheet.Cells["D" + row].Value.ToString().IsNumberic() ? int.Parse(sheet.Cells["D" + row].Value.ToString()) : 0,
                    PriceBuy = sheet.Cells["E" + row].Value.ToString().IsNumberic() ? int.Parse(sheet.Cells["E" + row].Value.ToString()) : 0,
                    Unit = units.Where(x => x.Value.Equals(sheet.Cells["F" + row].Value.ToString())).Select(x => x.Key).First(),
                    Price = (sheet.Cells["G" + row].Value != null && sheet.Cells["G" + row].Value.ToString().IsNumberic()) ? int.Parse(sheet.Cells["G" + row].Value.ToString()) : 0,
                    Ex = DateTime.Parse(sheet.Cells["H" + row].Value.ToString()),
                    Supplier = suppliers.Where(x => x.Value.Equals(sheet.Cells["I" + row].Value.ToString())).Select(x => x.Key).First(),

                    Discount = (sheet.Cells["K" + row].Value != null && sheet.Cells["K" + row].Value.ToString().IsNumberic()) ? double.Parse(sheet.Cells["K" + row].Value.ToString()) : 0,
                    DiscountBarcode1 = sheet.Cells["L" + row].Value != null ? sheet.Cells["L" + row].Value.ToString() : string.Empty,
                    DiscountQuantity1 = (sheet.Cells["M" + row].Value != null && sheet.Cells["M" + row].Value.ToString().IsNumberic()) ? int.Parse(sheet.Cells["M" + row].Value.ToString()) : 0,
                    DiscountBarcode2 = sheet.Cells["N" + row].Value != null ? sheet.Cells["N" + row].Value.ToString() : string.Empty,
                    DiscountQuantity2 = (sheet.Cells["O" + row].Value != null && sheet.Cells["O" + row].Value.ToString().IsNumberic()) ? int.Parse(sheet.Cells["O" + row].Value.ToString()) : 0,
                    DiscountBarcode3 = sheet.Cells["P" + row].Value != null ? sheet.Cells["P" + row].Value.ToString() : string.Empty,
                    DiscountQuantity3 = (sheet.Cells["Q" + row].Value != null && sheet.Cells["Q" + row].Value.ToString().IsNumberic()) ? int.Parse(sheet.Cells["Q" + row].Value.ToString()) : 0,
                    DiscountBarcode4 = sheet.Cells["R" + row].Value != null ? sheet.Cells["R" + row].Value.ToString() : string.Empty,
                    DiscountQuantity4 = (sheet.Cells["S" + row].Value != null && sheet.Cells["S" + row].Value.ToString().IsNumberic()) ? int.Parse(sheet.Cells["S" + row].Value.ToString()) : 0,
                };
                FillNameDiscount(ref elm, products);
                CalcDiscount(ref elm, products);
                elm.Cal();
                results.Add(elm);
            }
            var validMess = Valid(results, products);
            if (validMess.Length > 0) MessageUtil.Error(validMess);
            return results;
        }
        private string Valid(List<ImportProductModel> models, List<Product> products)
        {
            var mess = new StringBuilder();
            Product product;
            List<Product> discounts;
            foreach (var model in models)
            {
                product = products.FirstOrDefault(x => x.Barcode.Equals(model.Barcode));
                if (product == null) mess.AppendLine("Không tìm thấy sản phẩm: " + model.ProductName + ". Vui lòng kiểm tra lại.");
                discounts = model.ToDiscount();
                foreach (var discount in discounts)
                {
                    if (string.IsNullOrEmpty(discount.Barcode)) continue;
                    product = products.FirstOrDefault(x => x.Barcode.Equals(discount.Barcode));
                    if (product == null) mess.AppendLine("Không tìm thấy sản phẩm khuyến mại " + discount.Barcode + " của: " + model.ProductName + ". Vui lòng kiểm tra lại.");
                }
            }
            return mess.ToString();
        }

        private void CalcDiscount(ref ImportProductModel model, List<Product> products)
        {
            Product product;
            var discounts = model.ToDiscount();
            var totalQuantity = model.Quantity;
            var totalDiscount = 0;

            foreach (var discount in discounts)
            {
                if (string.IsNullOrEmpty(discount.Barcode)) continue;
                product = products.FirstOrDefault(x => x.Barcode.Equals(discount.Barcode));
                if (product != null)
                {
                    if (model.Barcode.Equals(discount.Barcode))
                        totalQuantity += 1;
                    else
                        totalDiscount += product.PriceBuy.Value * discount.Quantity;
                }
            }
            if (model.Discount > 0) model.Total = model.Total - Convert.ToInt32((model.Discount / 100) * model.Total);
            model.PriceBuy = ((model.Total - totalDiscount) / totalQuantity).Round100();
        }
        private void FillNameDiscount(ref ImportProductModel model, List<Product> products)
        {
            Product product = null;
            var tempModel = model;
            if(!string.IsNullOrEmpty(model.DiscountBarcode1)) product = products.FirstOrDefault(x => x.Barcode.Equals(tempModel.DiscountBarcode1));
            if (product != null) model.DiscountName1 = product.Name;
            product = null;
            if (!string.IsNullOrEmpty(model.DiscountBarcode2)) product = products.FirstOrDefault(x => x.Barcode.Equals(tempModel.DiscountBarcode2));
            if (product != null) model.DiscountName2 = product.Name;
            product = null;
            if (!string.IsNullOrEmpty(model.DiscountBarcode3)) product = products.FirstOrDefault(x => x.Barcode.Equals(tempModel.DiscountBarcode3));
            if (product != null) model.DiscountName3 = product.Name;
            product = null;
            if (!string.IsNullOrEmpty(model.DiscountBarcode4)) product = products.FirstOrDefault(x => x.Barcode.Equals(tempModel.DiscountBarcode4));
            if (product != null) model.DiscountName4 = product.Name;
        }

        public List<KeyValue> GetSuppliers()
        {
            return _db.Suppliers.Select(x => new KeyValue() { key = x.Id.ToString(), value = x.Name }).ToList();
        }

        public void CreateTemplate()
        {
            var excelPackage = new ExcelPackage(new FileInfo(Constants.ROOT_PATH + "\\Requiment\\temp.xlsx"));
            var workSheet = excelPackage.Workbook.Worksheets[1];

            var units = _db.Units.Select(x => x.Name).ToList();
            units.Sort();
            var unitValid = workSheet.DataValidations.AddListValidation("F2:F3");
            foreach (var elm in units)
            {
                unitValid.Formula.Values.Add(elm);
            }
            var suppliers = _db.Suppliers.Select(x => x.Name).ToList();
            suppliers.Sort();
            var supplierValid = workSheet.DataValidations.AddListValidation("I2:I3");
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
            var mess = datas.Count(x => x.Error != null && x.Error.Length > 0);
            if (mess > 0) return;
            var products = _db.Products.ToList();
            var units = _db.Units.ToList();

            List<Product> adds = new List<Product>();
            List<Product> edits = new List<Product>();
            List<ProductHistory> histories = new List<ProductHistory>();
            List<TransactionDetail> tranDetails = new List<TransactionDetail>();
            Product product;

            var options = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted };

            using (var scope = new TransactionScope(TransactionScopeOption.Required, options))
            {
                // transaction
                Entities.Transaction tran = new Entities.Transaction()
                {
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator",
                    Type = Constants.PURCHASE,
                    SuplierId = 0,
                    IsPayment = FrmImportProduct._dialogModel.IsDebt ? Constants.NOT_PAY : Constants.PAID,
                    Amount = FrmImportProduct._dialogModel.Total,
                    Payment = FrmImportProduct._dialogModel.Payment,
                    PayBack = FrmImportProduct._dialogModel.Payback
                };
                _db.Transactions.Add(tran);
                _db.SaveChanges();

                List<Product> discounts;
                TransactionDetail tranDetail;
                foreach (var elm in datas)
                {
                    discounts = elm.ToDiscount();
                    // product + history
                    product = products.FirstOrDefault(x => x.Barcode.Equals(elm.Barcode));
                    // not exist
                    if (product == null)
                    {
                        var add = elm.ToProduct();
                        add.CreatedAt = DateTime.Now;
                        add.CreatedBy = "Administrator";
                        adds.Add(add);
                        histories.Add(elm.ToProductHistory());
                    }
                    else
                    {
                        elm.DumpProduct(ref product);
                        _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                        histories.Add(elm.ToProductHistory(product));
                    }

                    // transaction detail
                    tranDetail = elm.ToTransactionDetail(tran.Id);

                    // discount
                    foreach (var discount in discounts)
                    {
                        product = products.First(x => x.Barcode.Equals(discount.Barcode));

                        histories.Add(new ProductHistory()
                        {
                            Barcode = discount.Barcode,
                            QuantityOld = product.Quantity,
                            QuantityNew = product.Quantity + discount.Quantity
                        });

                        if (discount.Barcode.Equals(elm.Barcode))
                            tranDetail.Quantity += discount.Quantity;
                        else
                            tranDetails.Add(new TransactionDetail()
                            {
                                Barcode = discount.Barcode,
                                TracsactionId = tran.Id,
                                Quantity = discount.Quantity,
                                IsDiscount = true,
                                Amount = product.PriceBuy.Value * discount.Quantity,
                                Unit = product.Unit,
                                CreatedAt = DateTime.Now,
                                CreatedBy = "Administrator"
                            });

                        product.Quantity += discount.Quantity;
                        product.UpdatedAt = DateTime.Now;
                        _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                    }
                    tranDetails.Add(tranDetail);
                }

                // insert
                if (adds.Count > 0) _db.Products.AddRange(adds);
                _db.ProductHistories.AddRange(histories);
                _db.TransactionDetails.AddRange(tranDetails);
                _db.SaveChanges();

                scope.Complete();
                MessageUtil.UpdateSuccess();
            }
        }
    }
}
