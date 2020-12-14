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
    public class ConvertMasterService: ServiceBase
    {
        public List<ConvertMasterModel> GetAll()
        {
            var query = _db.ConvertProducts.ToList();
            var keys = _db.ConvertProducts.Select(x => x.Barcode1).Distinct().ToList();
            keys.AddRange(_db.ConvertProducts.Select(x => x.Barcode2).Distinct().ToList());
            var products = _db.Products.Where(x => keys.Contains(x.Barcode)).ToList();
            var converts = new List<ConvertMasterModel>();
            foreach(var elm in query)
            {
                converts.Add(new ConvertMasterModel()
                {
                    Barcode1 = elm.Barcode1,
                    Name1 = products.Find(x=>x.Barcode.Equals(elm.Barcode1)).Name,
                    Quantity1 = elm.Quantity1,
                    Barcode2 = elm.Barcode2,
                    Quantity2 = elm.Quantity2,
                    Name2 = products.Find(x => x.Barcode.Equals(elm.Barcode2)).Name
                });
            }

            return converts;
        }

        public void Save(List<ConvertMasterModel> models)
        {
            _db.Database.BeginTransaction();
            try
            {
                var converts = Mapper.Map<List<ConvertMasterModel>, List<ConvertProduct>>(models);
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
