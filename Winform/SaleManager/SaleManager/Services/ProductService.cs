using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class ProductService
    {
        private SaleManagerEntities _db;
        public ProductService()
        {
            _db = new SaleManagerEntities();
        }

        public List<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public Product GetById(string barcode)
        {
            return _db.Products.Where(x => x.Barcode.Equals(barcode)).FirstOrDefault();
        }

        public List<Product> Search(string key, int categoryId = -1, int supplierId = -1)
        {
            var results = _db.Products.Where(x => (x.Barcode.Contains(key) || x.Name.Contains(key)) && x.Enable == true).AsQueryable();
            if (categoryId != -1)
                results = results.Where(x => x.CategoryId == categoryId).AsQueryable();
            if (supplierId != -1)
                results = results.Where(x => x.SupplierId == supplierId).AsQueryable();
            return results.ToList();
        }

        public bool Insert(Product data)
        {
            _db.Products.Add(data);
            return _db.SaveChanges() != 0;
        }

        public bool Insert(List<Product> datas)
        {
            var tran = _db.Database.BeginTransaction();
            try
            {
                var barcodes = datas.Select(x => x.Barcode).ToList();
                //Delete
                var deleteData = _db.Products.Where(x => barcodes.Contains(x.Barcode)).ToList();
                _db.Products.RemoveRange(deleteData);
                foreach (var elm in datas)
                {
                    elm.CreatedAt = DateTime.Now;
                    elm.CreatedBy = "Administrator";
                }
                _db.Products.AddRange(datas);
                _db.SaveChanges();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }
        }

        public bool Update(Product data)
        {
            var result = _db.Products.Where(x => x.Barcode.Equals(data.Barcode)).FirstOrDefault();
            if (result == null)
                throw new Exception("Không tìm thấy dữ liệu!");
            result.UpdatedAt = DateTime.Now;
            result.UpdatedBy = "Administrator";
            result.Name = data.Name;
            result.Quantity = data.Quantity;
            result.Price = data.Price;
            result.CategoryId = data.CategoryId;
            result.SupplierId = data.SupplierId;
            result.Pin = data.Pin;
            result.Enable = data.Enable;
            result.ExpirationDate = data.ExpirationDate;
            result.Unit = data.Unit;
            result.Img = data.Img;
            _db.Entry(result).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() != 0;
        }

        public bool Delete(string barcode)
        {
            var result = _db.Products.Where(x => x.Barcode.Equals(barcode)).FirstOrDefault();
            if (result == null)
                throw new Exception("Không tìm thấy dữ liệu!");
            _db.Products.Remove(result);
            return _db.SaveChanges() != 0;
        }

        public List<KeyValue> GetCategoryList()
        {
            return _db.Categories.Select(x => new KeyValue() { key = x.Id.ToString(), value = x.Name }).ToList();
        }

        public List<KeyValue> GetSupplierList()
        {
            return _db.Suppliers.Select(x => new KeyValue() { key = x.Id.ToString(), value = x.Name }).ToList();
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
