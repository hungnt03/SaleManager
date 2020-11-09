using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class TransactionDetailModel
    {
        public string Barcode { get; set; }
        public string ProductName { set; get; }
        public int TracsactionId { get; set; }
        public int Quantity { get; set; }
        public bool IsPayment { get; set; }
        public decimal Amount { get; set; }
        public int Unit { set; get; }
        public int Price { set; get; }
    }
}
