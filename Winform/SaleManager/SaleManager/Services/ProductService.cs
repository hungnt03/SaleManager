using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class ProductService : ServiceBase
    {
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
        public void Save(List<ProductModel> datas)
        {
            Product product;
            List<Product> adds = new List<Product>();
            _db.Database.BeginTransaction();
            var isSuccess = false;

            try
            {
                foreach (var p in datas)
                {
                    product = _db.Products.Find(p.Barcode, p.Unit);
                    if (product != null)
                    {
                        p.DumpProduct(ref product);
                        _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        product = Mapper.Map<ProductModel, Product>(p);
                        product.CreatedAt = DateTime.Now;
                        product.CreatedBy = "Administrator";
                        product.Img = product.Barcode + ".jpg";
                        adds.Add(product);
                    }
                }
                if (adds.Count > 0) _db.Products.AddRange(adds);

                isSuccess = _db.SaveChanges() != 0;
                _db.Database.CurrentTransaction.Commit();
            }
            catch (Exception e)
            {
                _db.Database.CurrentTransaction.Rollback();
                throw e;
            }

            //Upload image
            if (!isSuccess) return;
            foreach(var p in datas)
            {
                if (string.IsNullOrEmpty(p.Img)) continue;
                var imgRootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\";
                var imgName = p.Barcode + ".jpg";
                var file = new FileInfo(imgRootPath + imgName);
                if (file.Exists)
                    file.Delete();
                if(p.Image != null) p.Image.Save(imgRootPath + imgName, ImageFormat.Jpeg);
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
