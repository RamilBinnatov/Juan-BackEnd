using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class BlogCreateVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Intro { get; set; }
        [Required]
        public string Quote { get; set; }
        [Required]
        public string Context { get; set; }
        public IFormFile Photo { get; set; }
    }
}
