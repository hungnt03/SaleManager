using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities
{
    [Table("TransactionDetail")]
    public class TransactionDetail : Auditable
    {
        [StringLength(12)]
        public string Barcode { get; set; }
        [Column(Order = 2)]
        public int TracsactionId { get; set; }
        public int SuplierId { get; set; }
        public int Quantity { get; set; }
        public bool IsPayment { get; set; }
        public decimal Amount { get; set; }
    }
}
