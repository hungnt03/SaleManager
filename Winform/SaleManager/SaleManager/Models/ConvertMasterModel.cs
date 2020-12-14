using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class ConvertMasterModel: BaseModel
    {
        [Required]
        [StringLength(13)]
        public string Barcode1 { get; set; }
        public string Name1 { set; get; }
        [Required]
        public int Quantity1 { get; set; }
        [Required]
        [StringLength(13)]
        public string Barcode2 { get; set; }
        public string Name2 { set; get; }
        [Required]
        public int Quantity2 { get; set; }
    }
}
