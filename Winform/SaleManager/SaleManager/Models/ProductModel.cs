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
        public List<KeyValue> Categories { set; get; }
        public int CategoryId { get; set; }
        public List<KeyValue> Suppliers { set; get; }
        public int SupplierId { get; set; }
        public bool Pin { get; set; }
        public bool Enable { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Unit { get; set; }
        public string Img { get; set; }
        public Bitmap Image { get; set; }

        public ProductModel()
        {
            this.ExpirationDate = DateTime.Now;
        }
    }
}
