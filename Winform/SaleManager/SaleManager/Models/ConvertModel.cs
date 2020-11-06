using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ConvertModel: BaseModel
    {
        [Required]
        [StringLength(13)]
        public string Barcode { get; set; }
        public string Name { set; get; }
        [Required]
        public int Unit1 { get; set; }
        [Required]
        public int Quantity1 { get; set; }
        [Required]
        public int Unit2 { get; set; }
        [Required]
        public int Quantity2 { get; set; }
    }
}
