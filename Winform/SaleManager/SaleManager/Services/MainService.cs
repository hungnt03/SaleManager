using SaleManager.Controls;
using SaleManager.Entities;
using SaleManager.Models;
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
                Barcode = x.Barcode,
                Name =  x.Name,
                Price = x.Price,
                Img = x.Img,
                Unit = x.Unit
            }).ToList();
            return products;
        }

        public BillProductModel SearchBillProduct(string barcode)
        {
            var product = _db.Products.Where(x => (x.Barcode.Contains(barcode))).FirstOrDefault();
            if (product == null) return null;
            return (new BillProductModel(product));
        }
    }
}
