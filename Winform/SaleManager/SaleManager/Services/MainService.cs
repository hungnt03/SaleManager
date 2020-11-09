using SaleManager.Controls;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Utils;
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
            var products = _db.Products.Where(x => (x.Pin != null) && x.Pin == true && x.Enable == true).Select(x => new CardViewModel()
            {
                Barcode = x.Barcode,
                Name = x.Name,
                Price = x.Price,
                Img = x.Img,
                Unit = x.Unit
            }).ToList();
            return products;
        }

        public BillProductModel SearchBillProduct(string barcode)
        {
            var product = _db.Products
                .Where(x => x.Barcode.Contains(barcode) && x.IsDefault == true && x.Enable == true).FirstOrDefault();
            if (product == null) return null;
            return (new BillProductModel(product));
        }
        public List<CardViewModel> SearchProduct(string key)
        {
            var products = _db.Products.Where(
                x => (x.Pin != null) && x.Pin == true && x.Enable == true && x.Name.Contains(key)
                )
                .Select(x => new CardViewModel()
                {
                    Barcode = x.Barcode,
                    Name = x.Name,
                    Price = x.Price,
                    Img = x.Img,
                    Unit = x.Unit
                }).ToList();
            return products;
        }

        public bool Save(List<BillProductModel> bills, MainModel model)
        {
            _db.Database.BeginTransaction();
            try
            {
                Product product;
                var tranDetails = new List<TransactionDetail>();
                var productHistories = new List<ProductHistory>();
                var tran = _db.Transactions.Add(new Transaction()
                {
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator",
                    Type = Constants.SELL,
                    IsPayment = model.Payment < model.Total ? Constants.NOT_PAY : Constants.PAID,
                    Amount = model.Total,
                    Payment = model.Payment,
                    PayBack = model.Payback,
                    Note = model.Note
                });
                _db.SaveChanges();
                foreach (var bill in bills)
                {
                    product = _db.Products.Find(bill.Barcode, bill.Unit);
                    product.Quantity -= bill.Quantity;
                    _db.Entry(product).State = System.Data.Entity.EntityState.Modified;

                    tranDetails.Add(new TransactionDetail()
                    {
                        Barcode = bill.Barcode,
                        TracsactionId = tran.Id,
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Administrator",
                        Quantity = bill.Quantity,
                        Amount = bill.Total,
                        IsPayment = model.Payment < model.Total ? Constants.NOT_PAY : Constants.PAID,
                    });

                    productHistories.Add(new ProductHistory()
                    {
                        Barcode = product.Barcode,
                        Unit = product.Unit,
                        QuantityNew = product.Quantity - bill.Quantity,
                        QuantityOld = product.Quantity,
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Administrator"
                    });
                }

                _db.TransactionDetails.AddRange(tranDetails);
                _db.ProductHistories.AddRange(productHistories);

                _db.SaveChanges();
                _db.Database.CurrentTransaction.Commit();
                MessageUtil.UpdateSuccess();
                return true;
            }
            catch (Exception)
            {
                _db.Database.CurrentTransaction.Rollback();
                return false;
                throw;
            }
            return false;
        }
    }
}
