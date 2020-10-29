using SaleManager.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ProductModel
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int PriceBuy { get; set; }
        public int Interest { set; get; }
        public List<KeyValue> Categories { set; get; }
        public int CategoryId { get; set; }
        public List<Category> categories { set; get; }        
        public int SupplierId { get; set; }
        public List<Category> Suppliers { set; get; }
        public bool Pin { get; set; }
        public bool Enable { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UnitId { get; set; }
        public List<Unit> Units { set; get; }
        public string Img { get; set; }
        public Bitmap Image { get; set; }

        public ProductModel()
        {
            this.ExpirationDate = DateTime.Now;
        }
    }
}
