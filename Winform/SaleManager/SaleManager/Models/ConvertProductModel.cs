using SaleManager.Utils;

namespace SaleManager.Models
{
    public class ConvertProductModel : Bindable
    {
        public string Barcode1 { set; get; }
        public string Name1 { set; get; }
        public int Quantity1 { set; get; }
        public string Barcode2 { set; get; }
        public string Name2 { set; get; }

        private int _quantity2;
        public int Quantity2 { get => _quantity2; set => Set(ref _quantity2, value); }
    }
}
