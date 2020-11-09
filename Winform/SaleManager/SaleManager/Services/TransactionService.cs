using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class TransactionService : ServiceBase
    {
        public List<TransactionModel> GetAll()
        {
            var trans = _db.Transactions.Select(x => new TransactionModel()
            {
                Amount = x.Amount ?? -1,
                Id = x.Id,
                IsPayment = x.IsPayment,
                Note = x.Note,
                PayBack = x.PayBack ?? -1,
                Payment = x.Payment ?? -1,
                CreateAt = x.CreatedAt ?? DateTime.MinValue,
                Type = x.Type,
                SupplierId = x.SuplierId ?? -1
            }).ToList();
            return trans;
        }
        public List<TransactionModel> Search(bool isPayment, string key = null, int type = -1, DateTime? from = null, DateTime? to = null)
        {
            var trans = _db.Transactions.Where(x => x.IsPayment == isPayment).AsQueryable();
            if (!string.IsNullOrEmpty(key)) trans = trans.Where(x => x.Note.Contains(key)).AsQueryable();
            if (type != -1) trans = trans.Where(x => x.Type == type).AsQueryable();
            if (from != null && from != DateTime.MinValue) trans = trans.Where(x => x.CreatedAt >= from).AsQueryable();
            if (to != null && to != DateTime.MinValue) trans = trans.Where(x => x.CreatedAt <= to).AsQueryable();
            return trans.Select(x => new TransactionModel()
            {
                Amount = x.Amount ?? -1,
                Id = x.Id,
                IsPayment = x.IsPayment,
                Note = x.Note,
                PayBack = x.PayBack ?? -1,
                Payment = x.Payment ?? -1,
                CreateAt = x.CreatedAt ?? DateTime.MinValue,
                Type = x.Type,
                SupplierId = x.SuplierId ?? -1
            }).ToList();
        }
        public bool Save(List<TransactionModel> models)
        {
            _db.Database.BeginTransaction();
            try
            {
                Transaction tran;
                foreach(var model in models)
                {
                    tran = _db.Transactions.Find(model.Id);
                    if (tran == null) continue;
                    tran.IsPayment = model.IsPayment;
                    tran.Payment = model.Payment;
                    tran.PayBack = model.PayBack;
                    tran.Note = model.Note;
                    tran.UpdatedAt = DateTime.Now;
                    tran.UpdatedBy = "Administrator";
                    _db.Entry(tran).State = System.Data.Entity.EntityState.Modified;
                }
                _db.SaveChanges();
                _db.Database.CurrentTransaction.Commit();
                return true;
            }
            catch (Exception)
            {
                _db.Database.CurrentTransaction.Rollback();
                return false;
                throw;
            }
        }
    }
}
