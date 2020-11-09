using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class TransactionModel : Bindable
    {
        private int _amount;
        private int _payment;
        private int _payBack;
        public int Id { set; get; }
        public int Type { get; set; }
        public bool IsPayment { get; set; }
        public int Amount { get => _amount; set => Set(ref _amount, value); }
        public int Payment
        {
            get => _payment;
            set
            {
                Set(ref _payment, value);
                PayBack = value - Amount;
            }
        }
        public int PayBack { get => _payBack; set => Set(ref _payBack, value); }
        public string Note { get; set; }
        public DateTime CreateAt { set; get; }
        public int SupplierId { set; get; }
    }
}
