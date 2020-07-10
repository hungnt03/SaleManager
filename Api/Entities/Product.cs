using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    [Table("Product")]
    public class Product : Auditable
    {
        [Key]
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
}
