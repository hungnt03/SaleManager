using System.Drawing;

namespace SaleManager.Models
{
    public class BarcodeModel
    {
        public string Barcode { set; get; }
        public string ProductName { set; get; }
        public bool IsChecked { set; get; }
        public Image BarcodeImg { set; get; }
    }
}
