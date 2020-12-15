using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class SupplierService : ServiceBase
    {
        public List<SupplierModel> GetSuppliers()
        {
            return _db.Suppliers.Select(x => new SupplierModel() 
            {
                Name = x.Name,
                Contact1 = x.Contact1,
                Contact2 = x.Contact2,
                Address = x.Address,
                Id = x.Id,
                Note = x.Note
            }).OrderBy(x=>x.Name).ToList();
        }
        public void Save(List<Supplier> addDatas)
        {
            var tran = _db.Database.BeginTransaction();
            try
            {
                var suppliers = _db.Suppliers.ToList();
                _db.Suppliers.RemoveRange(suppliers);
                _db.Suppliers.AddRange(addDatas);
                _db.SaveChanges();
                tran.Commit();
                MessageUtil.UpdateSuccess();
            }
            catch (Exception)
            {
                tran.Rollback();
                MessageUtil.UpdateFailed();
            }
        }

        public void Delete(int id)
        {
            var supplier = _db.Suppliers.Where(x => x.Id == id).FirstOrDefault();
            if (supplier != null)
            {
                _db.Suppliers.Remove(supplier);
                _db.SaveChanges();
                MessageUtil.UpdateSuccess();
                return;
            }
            MessageUtil.UpdateFailed();
        }
    }
}
