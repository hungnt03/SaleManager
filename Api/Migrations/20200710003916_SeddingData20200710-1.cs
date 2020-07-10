using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class SeddingData202007101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 10, 9, 39, 16, 38, DateTimeKind.Local).AddTicks(3993), "administrator", "Các loại hàng về Thực phẩm", "Thực phẩm", null, null },
                    { 2, new DateTime(2020, 7, 10, 9, 39, 16, 39, DateTimeKind.Local).AddTicks(9686), "administrator", "Các loại hàng về Rượu bia", "Rượu bia", null, null },
                    { 3, new DateTime(2020, 7, 10, 9, 39, 16, 39, DateTimeKind.Local).AddTicks(9714), "administrator", "Các loại hàng về Thuốc lá", "Thuốc lá", null, null },
                    { 4, new DateTime(2020, 7, 10, 9, 39, 16, 39, DateTimeKind.Local).AddTicks(9716), "administrator", "Các loại hàng về Mỹ phẩm", "Mỹ phẩm", null, null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "Contact", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội", "02438267984", new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(3281), "administrator", "Nguyễn Hữu Hoà", null, null },
                    { 2, "59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội", "02438226676", new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(3347), "administrator", "Trần Danh Mạnh", null, null },
                    { 3, "35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội", "02436230311", new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(3349), "administrator", "Hoàng Tố Như", null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Barcode", "CategoryId", "CreatedAt", "CreatedBy", "Enable", "ExpirationDate", "Img", "Name", "Pin", "Price", "Quantity", "SupplierId", "Unit", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "8938503112147", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8578), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8575), "", "Mít sấy Vinamit gói 500g", false, 143600, 20, 1, "Gói", null, null },
                    { "8936124472008", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8574), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8572), "", "Đậu phộng nước cốt dừa Tân Tân gói 75g", false, 10000, 30, 1, "Gói", null, null },
                    { "8936028040426", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8571), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8569), "", "Sốt gia vị chinsu", false, 15000, 100, 1, "Gói", null, null },
                    { "8936017367046", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8568), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8566), "", "Tương cà chinsu 250g", false, 12000, 50, 1, "Chai", null, null },
                    { "8936017364113", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8565), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8563), "", "Nước mắm Cá cốt ABC", false, 12000, 15, 2, "Chai", null, null },
                    { "8935009922225", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8562), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8559), "", "Kẹo gấu thiên hồng 1kg", false, 95000, 15, 1, "Gói", null, null },
                    { "8934752060109", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8552), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8550), "", "Dấm trung thành 500ml", false, 10400, 50, 1, "Chai", null, null },
                    { "8934804004044", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8555), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8553), "", "Dầu hào 350g", false, 21000, 30, 2, "Chai", null, null },
                    { "8934637514871", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8548), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8544), "", "Sốt ướp thịt nướng", false, 16000, 30, 1, "Gói", null, null },
                    { "8004800008152", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8541), "administrator", true, new DateTime(2021, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8475), "", "Bánh Sampa Balocco Savoiardi 200g", false, 59000, 20, 1, "Gói", null, null },
                    { "3110354325000", 3, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8435), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(5131), "", "Thuốc lá Thăng Long", false, 10000, 63, 1, "Bao", null, null },
                    { "8934988021028", 1, new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8558), "administrator", true, new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8556), "", "Dầu ăn simply 2l", false, 130000, 10, 2, "Chai", null, null }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "Address", "Contact1", "Contact2", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội", "02437281476", null, new DateTime(2020, 7, 10, 9, 39, 16, 42, DateTimeKind.Local).AddTicks(751), "administrator", "Nguyễn Thị Thuỷ(bibica)", null, null },
                    { 2, "25 Văn Miếu, Đống Đa, Hà Nội, Vietnam", null, null, new DateTime(2020, 7, 10, 9, 39, 16, 42, DateTimeKind.Local).AddTicks(758), "administrator", "Nguyễn Đức Cảnh(ĐL cấp 1)", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "3110354325000");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8004800008152");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8934637514871");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8934752060109");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8934804004044");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8934988021028");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8935009922225");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8936017364113");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8936017367046");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8936028040426");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8936124472008");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Barcode",
                keyValue: "8938503112147");

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
