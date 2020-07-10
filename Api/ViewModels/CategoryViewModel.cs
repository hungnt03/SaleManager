using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class CategoryIViewModel
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
    public class CategoryUViewModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
    public class CategoryDViewModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
