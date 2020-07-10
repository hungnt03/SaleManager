using System.ComponentModel.DataAnnotations;

namespace Api.ViewModels
{
    public class SupplierIViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        [Phone]
        [StringLength(250)]
        public string Contact1 { get; set; }
        [StringLength(250)]
        [Phone]
        public string Contact2 { get; set; }
    }
    public class SupplierUViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        [Phone]
        [StringLength(250)]
        public string Contact1 { get; set; }
        [StringLength(250)]
        [Phone]
        public string Contact2 { get; set; }
    }
    public class SupplierDViewModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [Phone]
        [StringLength(250)]
        public string Contact1 { get; set; }
        [StringLength(250)]
        [Phone]
        public string Contact2 { get; set; }
    }
}
