using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slider : BaseEntity
    {
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Can't be empty")]
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }

    }
}
