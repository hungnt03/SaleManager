using System.ComponentModel.DataAnnotations;

namespace Api.ViewModels
{
    public class CustomerIViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(11)]
        [Phone]
        [Required]
        public string Contact { get; set; }
    }

    public class CustomerUViewModel
    {
        [Required(ErrorMessage = "{0} không được để trống.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(11)]
        [Phone]
        [Required]
        public string Contact { get; set; }
    }

    public class CustomerDViewModel
    {
        [Required(ErrorMessage = "{0} không được để trống.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(11)]
        [Phone]
        public string Contact { get; set; }
    }
}
