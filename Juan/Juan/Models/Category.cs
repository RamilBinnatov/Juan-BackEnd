using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Name can't be empty")]
        public string Name { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
