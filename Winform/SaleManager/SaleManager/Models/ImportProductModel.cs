using SaleManager.Entities;
using SaleManager.Utils;
using SaleManager.Views;
using System;
using System.ComponentModel.DataAnnotations;

namespace SaleManager.Models
{
    public class ImportProductModel : Bindable
    {
        [Required]
        [StringLength(13)]
        public string Barcode { set; get; }
        public string ProductName { set; get; }
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int Total { set; get; }
        public int PriceBuy { set; get; }
        public int Quantity { set; get; }
        public int Unit { set; get; }
        public int Price { set; get; }
        public int Supplier { set; get; }
        public Nullable<DateTime> Ex { set; get; }
        public int Interest { set; get; }

        [RegularExpression("([0-9.,]+)", ErrorMessage = "Please enter valid Number")]
        public double Discount { set; get; }
        [Required]
        [StringLength(13)]
        public string DiscountBarcode1 { set; get; }
        [Required]
        [StringLength(13)]
        public string DiscountBarcode2 { set; get; }
        [Required]
        [StringLength(13)]
        public string DiscountBarcode3 { set; get; }
        [Required]
        [StringLength(13)]
        public string DiscountBarcode4 { set; get; }
        public int DiscountQuantity1 { set; get; }
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int DiscountQuantity2 { set; get; }
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int DiscountQuantity3 { set; get; }
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int DiscountQuantity4 { set; get; }

        public void Cal()
        {
            if (Interest == 0)
                Interest = Price - PriceBuy;
            if (Price == 0)
                Price = PriceBuy + Interest;
        }

        public Product ToProduct()
        {
            var result = new Product();
            result.Barcode = this.Barcode;
            result.Name = this.ProductName;
            result.Quantity = this.Quantity;
            result.Price = this.Price;
            result.SupplierId = Supplier;
            result.Enable = true;
            result.ExpirationDate = Ex;
            result.Unit = this.Unit;
            result.PriceBuy = this.PriceBuy;
            result.Interest = this.Interest;
            return result;
        }

        public ProductHistory ToProductHistory(Product product = null)
        {
            var result = new ProductHistory();
            result.Barcode = this.Barcode;
            result.Unit = this.Unit;
            result.NameNew = this.ProductName;
            result.QuantityNew = this.Quantity;
            result.PriceNew = this.Price;
            result.SupplierIdNew = Supplier;
            result.ExpirationDateNew = Ex;
            result.PriceBuyNew = this.PriceBuy;
            result.InterestNew = this.Interest;
            result.Status = Constants.INSERT;
            if(product != null)
            {
                result.NameOld = product.Name;
                result.PriceOld = product.Price;
                result.PriceBuyOld = product.PriceBuy;
                result.InterestOld = product.Interest;
                result.QuantityOld = product.Quantity;
                result.ExpirationDateOld = product.ExpirationDate;
                result.Status = Constants.UPDATE;
                result.QuantityNew = this.Quantity + product.Quantity;
                result.SupplierIdOld = product.SupplierId;
            }
            result.CreatedAt = DateTime.Now;
            result.CreatedBy = "Administrator";
            return result;
        }
        public TransactionDetail ToTransactionDetail(int transactionId)
        {
            var result = new TransactionDetail();
            result.Barcode = this.Barcode;
            result.TracsactionId = transactionId;
            result.CreatedAt = DateTime.Now;
            result.CreatedBy = "Administrator";
            result.Quantity = this.Quantity;
            result.IsPayment = FrmImportProduct._dialogModel.IsDebt ? Constants.NOT_PAY : Constants.PAID;
            result.Amount = this.Total;
            result.Unit = this.Unit;
            return result;
        }

        public void DumpProduct(ref Product data)
        {
            data.Quantity += this.Quantity;
            data.Price = this.Price;
            data.SupplierId = Supplier;
            data.ExpirationDate = Ex;
            data.PriceBuy = this.PriceBuy;
            data.Interest = this.Interest;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "Administrator";
        }
    }
}
