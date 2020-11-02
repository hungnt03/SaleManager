using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class MainService : ServiceBase
    {
        public List<CardViewModel> GetPinProducts()
        {
            var products = _db.Products.Where(x => (x.Pin != null) && x.Pin == true && x.Enable == true).Select(x=>new CardViewModel() {
                id = x.Barcode,
                Name =  x.Name,
                Price = x.Price,
                //Picture = x.Img != null ? new Bitmap(System.Drawing.Image.FromFile(
                //        Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\" + x.Img)) : null
            }).ToList();
            return products;
        }
    }
}
