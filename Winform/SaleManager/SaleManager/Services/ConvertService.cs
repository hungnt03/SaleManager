using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaleManager.Services
{
    public class ConvertService: ServiceBase
    {
        public List<ConvertModel> GetAll()
        {
            var query = _db.ConvertProducts
                .Join(_db.Products,
                c => c.Barcode,
                p => p.Barcode,
                (c, p) => new { ConvertProducts = c, Products = p })
                .Select(x=>new { 
                    Barcode = x.ConvertProducts.Barcode,
                    Name = x.Products.Name,
                    Quantity1 = x.ConvertProducts.Quantity1,
                    Unit1 = x.ConvertProducts.Unit1,
                    Quantity2 = x.ConvertProducts.Quantity2,
                    Unit2 = x.ConvertProducts.Unit2,
                }).ToList();

            var results = new List<ConvertModel>();
            foreach (var elm in query)
            {
                results.Add(new ConvertModel()
                {
                    Barcode = elm.Barcode,
                    Name = elm.Name,
                    Quantity1 = elm.Quantity1,
                    Unit1 = elm.Unit1,
                    Quantity2 = elm.Quantity2,
                    Unit2 = elm.Unit2,
                });
            }
            return results;
        }

        public void Update(List<ConvertModel> models)
        {
            var converts = _db.ConvertProducts.ToList();
            ConvertProduct convert; 
            foreach(var elm in models)
            {
                //convert = converts.Where(x=>x.Barcode.Equals(elm.Barcode) && x.Unit1.Equals())
            }
        }
    }
}
