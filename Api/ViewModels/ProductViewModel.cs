using System;
using System.ComponentModel.DataAnnotations;

namespace Api.ViewModels
{    
    public class ProductViewModel
    {
        [StringLength(16)]
        public string Barcode { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public bool? Pin { get; set; }
        public bool Enable { get; set; }
        public DateTime? ExpirationDate { set; get; }
        [StringLength(50)]
        public string Unit { set; get; }
        public string Img { set; get; }
    }
    public class ProductSViewModel
    {
        public int? CategoryId { set; get; }
        public string? Name { set; get; }
        public int? PageNumber { set; get; }
    }
}
