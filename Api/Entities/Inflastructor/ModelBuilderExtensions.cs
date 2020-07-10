using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities.Inflastructor
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Thực phẩm", Description = "Các loại hàng về Thực phẩm", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Category { Id = 2, Name = "Rượu bia", Description = "Các loại hàng về Rượu bia", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Category { Id = 3, Name = "Thuốc lá", Description = "Các loại hàng về Thuốc lá", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Category { Id = 4, Name = "Mỹ phẩm", Description = "Các loại hàng về Mỹ phẩm", CreatedAt = DateTime.Now, CreatedBy = "administrator" }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Nguyễn Hữu Hoà", Address = "11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội", Contact = "02438267984", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Customer { Id = 2, Name = "Trần Danh Mạnh", Address = "59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội", Contact = "02438226676", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Customer { Id = 3, Name = "Hoàng Tố Như", Address = "35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội", Contact = "02436230311", CreatedAt = DateTime.Now, CreatedBy = "administrator" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { Barcode = "3110354325000", CategoryId = 3, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Thuốc lá Thăng Long", Pin = false, Price = 10000, Quantity = 63, SupplierId = 1, Unit = "Bao", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8004800008152", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(12), Img = "", Name = "Bánh Sampa Balocco Savoiardi 200g", Pin = false, Price = 59000, Quantity = 20, SupplierId = 1, Unit = "Gói", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8934637514871", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Sốt ướp thịt nướng", Pin = false, Price = 16000, Quantity = 30, SupplierId = 1, Unit = "Gói", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8934752060109", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Dấm trung thành 500ml", Pin = false, Price = 10400, Quantity = 50, SupplierId = 1, Unit = "Chai", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8934804004044", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Dầu hào 350g", Pin = false, Price = 21000, Quantity = 30, SupplierId = 2, Unit = "Chai", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8934988021028", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Dầu ăn simply 2l", Pin = false, Price = 130000, Quantity = 10, SupplierId = 2, Unit = "Chai", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8935009922225", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Kẹo gấu thiên hồng 1kg", Pin = false, Price = 95000, Quantity = 15, SupplierId = 1, Unit = "Gói", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8936017364113", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Nước mắm Cá cốt ABC", Pin = false, Price = 12000, Quantity = 15, SupplierId = 2, Unit = "Chai", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8936017367046", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Tương cà chinsu 250g", Pin = false, Price = 12000, Quantity = 50, SupplierId = 1, Unit = "Chai", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8936028040426", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Sốt gia vị chinsu", Pin = false, Price = 15000, Quantity = 100, SupplierId = 1, Unit = "Gói", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8936124472008", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Đậu phộng nước cốt dừa Tân Tân gói 75g", Pin = false, Price = 10000, Quantity = 30, SupplierId = 1, Unit = "Gói", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Product { Barcode = "8938503112147", CategoryId = 1, Enable = true, ExpirationDate = DateTime.Now.AddMonths(20), Img = "", Name = "Mít sấy Vinamit gói 500g", Pin = false, Price = 143600, Quantity = 20, SupplierId = 1, Unit = "Gói", CreatedAt = DateTime.Now, CreatedBy = "administrator" }
            );
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Nguyễn Thị Thuỷ(bibica)", Address = "183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội", Contact1 = "02437281476", CreatedAt = DateTime.Now, CreatedBy = "administrator" },
                new Customer { Id = 2, Name = "Nguyễn Đức Cảnh(ĐL cấp 1)", Address = "25 Văn Miếu, Đống Đa, Hà Nội, Vietnam", Contact = "02438433350", CreatedAt = DateTime.Now, CreatedBy = "administrator" }
            );
        }
    }
}
