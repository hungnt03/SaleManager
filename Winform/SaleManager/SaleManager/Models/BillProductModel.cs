using SaleManager.Entities;
using SaleManager.Utils;

namespace SaleManager.Models
{
    public class BillProductModel : Bindable
    {
        public string Barcode { set; get; }
        public string ProductName { set; get; }
        private int _price;
        public int Price { set => Set(ref _price, value); get => _price; }
        private int _quantity;
        public int Quantity
        {
            set
            {
                Set(ref _quantity, value);
                Total = this.Price * this.Quantity;
            }
            get => _quantity;
        }
        private int _unit;
        public int Unit { set {
                Set(ref _unit, value);
            }  get => _unit; }
        public string QuantityDown { set; get; }
        public string QuantityUp { set; get; }

        private int _total;
        public int Total { set => Set(ref _total, value); get => _total; }
        public string Del { set; get; }

        public BillProductModel()
        {
            this.Quantity = 1;
        }

        public BillProductModel(string barcode, string name, int price)
        {
            this.Barcode = barcode;
            this.ProductName = name;
            this.Price = price;
            this.Quantity = 1;
        }

        public BillProductModel(Product product)
        {
            this.Barcode = product.Barcode;
            this.ProductName = product.Name;
            this.Price = product.Price;
            this.Quantity = 1;
            this.Unit = product.Unit;
        }
    }
}
