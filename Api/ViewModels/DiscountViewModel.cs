using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class DiscountIViewModel
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Barcode { get; set; }
        [Required]
        public int Type { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public System.DateTime StartDate { get; set; }
        [Required]
        public System.DateTime EndDate { get; set; }
    }
    public class DiscountUViewModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(10)]
        public string Barcode { get; set; }
        [Required]
        public int Type { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public System.DateTime StartDate { get; set; }
        [Required]
        public System.DateTime EndDate { get; set; }
    }
    public class DiscountDViewModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(10)]
        public string Barcode { get; set; }
        public int Type { get; set; }
        public int CategoryId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    }
}
