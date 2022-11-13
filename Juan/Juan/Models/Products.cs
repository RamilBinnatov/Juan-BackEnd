using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Products : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
