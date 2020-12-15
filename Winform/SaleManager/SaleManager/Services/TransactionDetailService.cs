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

        public bool Save(int id, List<TransactionDetailModel> models)
        {
            _db.Database.BeginTransaction();
            try
            {
                var details = _db.TransactionDetails.Where(x => x.TracsactionId == id).ToList();
                _db.TransactionDetails.RemoveRange(details);
                var newDetails = new List<TransactionDetail>();


            }
            catch (Exception)
            {

                throw;
            }
            return false;
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
