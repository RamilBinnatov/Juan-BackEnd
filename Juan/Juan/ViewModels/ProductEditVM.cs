using Juan.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class ProductEditVM
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int Discound { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
