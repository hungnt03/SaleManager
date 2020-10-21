using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ConvertModel
    {
        public string Barcode { get; set; }
        public string Name { set; get; }
        public int Unit1 { get; set; }
        public int Quantity1 { get; set; }
        public int Unit2 { get; set; }
        public int Quantity2 { get; set; }
    }
}
