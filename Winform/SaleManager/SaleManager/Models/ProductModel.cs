using SaleManager.Entities;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ProductModel : Bindable
    {
        private Bitmap _image;
        private string _img;
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public bool Pin { get; set; }
        public bool Enable { get; set; }
        public bool IsDefault { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Unit { get; set; }
        public string Img
        {
            get => _img;
            set {
                Set(ref _img, value);         
                if(new FileInfo(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\" + _img).Exists)
                    Image = new Bitmap(System.Drawing.Image.FromFile(
                        Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\" + _img));
            }
        }
        public Bitmap Image { get => _image; set => Set(ref _image, value); }
        public int PriceBuy { get; set; }
        public int Interest { get; set; }

        public ProductModel()
        {
            this.ExpirationDate = DateTime.Now;
            this.Enable = true;
        }

        public void DumpProduct(ref Product product)
        {
            product.Name = this.Name;
            product.Quantity = this.Quantity;
            product.Price = this.Price;
            product.CategoryId = this.CategoryId;
            product.SupplierId = this.SupplierId;
            product.Pin = this.Pin;
            product.Enable = this.Enable;
            product.IsDefault = this.IsDefault;
            product.ExpirationDate = this.ExpirationDate;
            product.Unit = this.Unit;
            if(!string.IsNullOrEmpty(this.Img)) product.Img = Barcode + ".jpg";
            product.PriceBuy = this.PriceBuy;
            product.Interest = this.Interest;
            product.UpdatedAt = DateTime.Now;
            product.UpdatedBy = "Administrator";
        }
    }
}
