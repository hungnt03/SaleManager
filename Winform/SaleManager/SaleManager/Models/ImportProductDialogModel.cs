using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ImportProductDialogModel : Bindable
    {
        private int _total;
        private int _payment;
        public bool IsDebt { set; get; }
        public int Total { get => _total; set => Set(ref _total, value); }
        public int Payment { get => _payment; set => Set(ref _payment, value); }
        public int Payback
        {
            get
            {
                return Payment - Total;
            }
        }
    }
}
