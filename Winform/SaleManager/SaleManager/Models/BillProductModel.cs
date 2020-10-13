using Microsoft.SqlServer.Server;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class BillProductModel
    {
        public string barcode { set; get; }
        public string name { set; get; }
        public int quantity { set; get; }
        public string quantityDown;
        public string quantityUp;
        private string _price;
        public string price
        {
            get
            {
                return _price;
            }
            set
            {
                if (StringUtil.IsNumberic(value))
                {
                    _price = StringUtil.ToCurrentcy(int.Parse(value));
                }
            }
        }
        public string total { 
            get 
            {
                if (StringUtil.IsNumberic(this._price))
                    return StringUtil.ToCurrentcy(StringUtil.ConvertCurrentcy(this._price) * quantity);
                return "0";
            } 
        }
        public string del;

        public BillProductModel()
        {

        }

        public BillProductModel(string barcode, string name, int quantity, string price)
        {
            this.barcode = barcode;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
