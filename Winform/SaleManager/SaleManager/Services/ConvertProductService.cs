using SaleManager.Models;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.Services
{
    public class ConvertProductService : ServiceBase
    {
        public List<ProductModel> GetProducts()
        {
            return _db.Products
                 .Where(x => x.Enable)
                 .Select(x => new ProductModel()
                 {
                     Barcode = x.Barcode,
                     Name = x.Name,
                 })
                 .OrderBy(x => x.Name)
                 .ToList();
        }

        public int Convert(string barcode1, int quantity1, string barcode2)
        {
            var convert = _db.ConvertProducts.Where(x => x.Barcode1.Equals(barcode1) && x.Barcode2.Equals(barcode2)).FirstOrDefault();
            if (convert == null)
            {
                MessageUtil.Error("Không tồn tại luật chuyển đổi này!.");
                return 0;
            }
            var result = (convert.Quantity2 * quantity1) / convert.Quantity1;
            if (MessageUtil.InformationConfirm("Bạn có muốn chuyển đổi sản phẩm từ " + quantity1 + " sang " + result + "? ") == DialogResult.No) return result;

            // Convert
            var tran = _db.Database.BeginTransaction();
            try
            {
                var product1 = _db.Products.Where(x => x.Barcode.Equals(barcode1)).First();
                var product2 = _db.Products.Where(x => x.Barcode.Equals(barcode2)).First();
                product1.Quantity -= 1;
                product2.Quantity += result;
                _db.SaveChanges();
                tran.Commit();
                MessageUtil.UpdateSuccess();
            }
            catch (Exception)
            {
                tran.Rollback();
                MessageUtil.Error("Xảy ra lỗi trong quá trình chuyển đổi.");
                throw;
            }
            return result;
        }
    }
}
