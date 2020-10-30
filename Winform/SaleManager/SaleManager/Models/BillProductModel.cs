using Microsoft.SqlServer.Server;
using SaleManager.Entities;
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
        public int _quantity { set; get; }
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                _total = (int.Parse(this._price) * quantity).ToString();
            }
        }
        public string quantityDown;
        public string quantityUp;
        private string _price;
        public string price
        {
            get
            {
                return _price.ToCurrentcy();
            }
            set
            {
                if (value.IsNumberic())
                {
                    _price = value;
                }
            }
        }
        public string _total;
        public string total {
            set
            {
                _total = value;
            }
            get 
            {
                if (this._total.IsNumberic())
                    return _total.ToCurrentcy();
                return "0";
            }
        }
        public string del;

        public BillProductModel()
        {

        }

        public BillProductModel(string barcode, string name, string price)
        {
            this.barcode = barcode;
            this.name = name;
            this.price = price;
            this.quantity = 1;
        }

        public BillProductModel(Product product)
        {
            this.barcode = product.Barcode;
            this.name = product.Name;
            this.price = product.Price.ToString();
            this.quantity = 1;
        }
    }
}
