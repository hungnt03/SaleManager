using SaleManager.Utils;
using System.Drawing;

namespace SaleManager.Controls
{
    public class CardViewModel
    {
        private string _img;
        public string Name { get; set; }
        public int Price { get; set; }
        public Bitmap Picture { get; set; }
        public string Barcode { set; get; }
        public int Unit { set; get; }
        public string Img
        {
            set
            {
                this._img = value;
                if (!string.IsNullOrEmpty(value))
                    Picture = new Bitmap(System.Drawing.Image.FromFile(Constants.ROOT_PATH + "\\Resources\\Product\\" + value));
            }
            get => _img;
        }
    }
}
