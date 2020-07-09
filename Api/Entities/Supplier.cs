using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities
{
    [Table("Supplier")]
    public class Supplier : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(250)]
        public string Contact1 { get; set; }
        [StringLength(250)]
        public string Contact2 { get; set; }
    }
}
