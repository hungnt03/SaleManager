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
        public Nullable<DateTime> Ex { set; get; }
    }
}
