using SaleManager.Controls;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.Models
{
    public class MainModel : Bindable
    {
        public string _billKey;
        public string _cardKey;
        public int _total;
        public int _payment;
        public int _payback;
        public string Note { set; get; }
        public string BillKey { get => _billKey; set => Set(ref _billKey, value); }
        public string CardKey { get => _cardKey; set => Set(ref _cardKey, value); }
        public int Total { get => _total; set => Set(ref _total, value); }
        public int Payment
        {
            get => _payment;
            set
            {
                Set(ref _payment, value);
                Payback = value - Total;
            }
        }
        public int Payback { get => _payback; set => Set(ref _payback, value); }
        public MainModel()
        {
            Total = 0;
            Payment = 0;
        }
    }
}
