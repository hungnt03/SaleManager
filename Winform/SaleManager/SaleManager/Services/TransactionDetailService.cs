using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SaleManager.Services
{
    public class TransactionDetailService : ServiceBase
    {
        public List<TransactionDetailModel> FindById(int id)
        {
            var details = _db.TransactionDetails
                .Where(x => x.TracsactionId == id)
                .Select(x => new TransactionDetailModel()
                {
                    Id = x.TracsactionId,
                    Amount = x.Amount,
                    Barcode = x.Barcode,
                    Quantity = x.Quantity,
                    TracsactionId = x.TracsactionId,
                    IsPayment = x.IsPayment,
                    Unit = x.Unit ?? -1
                }).ToList();
            var barcodes = details.Select(x => x.Barcode).ToList();
            var products = _db.Products.Where(x => barcodes.Contains(x.Barcode)).ToList();
            foreach(var detail in details)
            {
                var product = products.Find(x => x.Barcode.Equals(detail.Barcode) && x.Unit == detail.Unit);
                if (product == null) continue;
                detail.Price = product.Price;
                detail.ProductName = product.Name;
            }
            return details;
        }

        public void Save(List<TransactionDetailModel> models)
        {
            var transaction = _db.Database.BeginTransaction();
            try
            {
                var trans = _db.TransactionDetails.ToList().FindAll(x=>x.TracsactionId== models[0].Id);
                TransactionDetail tran;
                foreach (var model in models)
                {
                    tran = trans.Find(x => x.Barcode.Equals(model.Barcode));
                    if (tran == null) continue;
                    tran.Amount = model.Amount;
                    tran.Unit = model.Unit;
                    tran.Quantity = model.Quantity;
                    tran.UpdatedAt = DateTime.Now;
                    tran.UpdatedBy = "Administrator";
                }
                _db.SaveChanges();
                transaction.Commit();
                MessageUtil.UpdateSuccess();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                MessageUtil.UpdateFailed();
            }
        }
        public void Delete(int id, string barcode)
        {
            var options = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted };
            using (var scope = new TransactionScope(TransactionScopeOption.Required, options))
            {
                var detail = _db.TransactionDetails.Where(x => x.TracsactionId == id && x.Barcode.Equals(barcode)).First();
                _db.TransactionDetails.Remove(detail);
                _db.SaveChanges();
                var presentCount = _db.TransactionDetails.Where(x => x.TracsactionId == id).Count();
                // if all detail deleted, transaction is required delete
                if(presentCount == 0)
                {
                    var transaction = _db.Transactions.Where(x => x.Id == id).First();
                    _db.Transactions.Remove(transaction);
                    _db.SaveChanges();
                }
                scope.Complete();
                MessageUtil.UpdateSuccess();
            }
        }
    }
}
