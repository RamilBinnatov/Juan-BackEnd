using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class ProductCreateVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int Discound { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
