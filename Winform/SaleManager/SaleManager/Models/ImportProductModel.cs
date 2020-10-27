using SaleManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ImportProductModel
    {
        public string Barcode { set; get; }
        public string ProductName { set; get; }
        public int Total { set; get; }
        public int PriceBuy { set; get; }
        public int Quantity { set; get; }
        public int Unit { set; get; }
        public int Price { set; get; }
        public int Supplier { set; get; }
        public Nullable<DateTime> Ex { set; get; }
        public int Interest { set; get; }

        public void Cal()
        {
            if (Interest == 0)
                Interest = Price - PriceBuy;
            if (Price == 0)
                Price = PriceBuy + Interest;
        }

        public Product ToProduct()
        {
            var result = new Product();
            result.Barcode = this.Barcode;
            result.Name = this.ProductName;
            result.Quantity = this.Quantity;
            result.Price = this.Price;
            result.SupplierId = Supplier;
            result.Enable = true;
            result.ExpirationDate = Ex;
            result.Unit = this.Unit;
            result.PriceBuy = this.PriceBuy;
            result.Interest = this.Interest;
            return result;
        }

        public Product ToProduct(Product data)
        {
            var result = new Product();
            result.Barcode = this.Barcode;
            result.Name = this.ProductName;
            result.Quantity = this.Quantity;
            result.Price = this.Price;
            result.SupplierId = Supplier;
            result.Enable = true;
            result.ExpirationDate = Ex;
            result.Unit = this.Unit;
            result.PriceBuy = this.PriceBuy;
            result.Interest = this.Interest;
            result.CreatedAt = data.CreatedAt;
            result.CreatedBy = data.CreatedBy;
            result.UpdatedAt = DateTime.Now;
            result.UpdatedBy = "Administrator";
            result.CategoryId = data.CategoryId;
            result.Pin = data.Pin;
            result.Enable = data.Enable;
            result.Img = data.Img;
            return result;
        }
    }
}
