using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Amount = x.Amount,
                    Barcode = x.Barcode,
                    Quantity = x.Quantity,
                    TracsactionId = x.TracsactionId,
                    IsPayment = x.IsPayment,
                    Unit = x.Unit ?? -1
                }).ToList();
            var barcodes = details.Select(x => x.Barcode).ToList();
            var products = _db.Products.Where(x => barcodes.Contains(x.Barcode)).AsQueryable();
            foreach(var detail in details)
            {
                
            }
        }
    }
}
