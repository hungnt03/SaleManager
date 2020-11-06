using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                }).Distinct().ToList();

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

        public void Save(List<ConvertModel> models)
        {
            _db.Database.BeginTransaction();
            try
            {
                var converts = Mapper.Map<List<ConvertModel>, List<ConvertProduct>>(models);
                _db.ConvertProducts.RemoveRange(_db.ConvertProducts.ToList());
                _db.ConvertProducts.AddRange(converts);
                _db.SaveChanges();
                _db.Database.CurrentTransaction.Commit();
                MessageBox.Show("Lưu thành công.");
            }
            catch (Exception)
            {
                _db.Database.CurrentTransaction.Rollback();
                throw;
            }
        }
    }
}
