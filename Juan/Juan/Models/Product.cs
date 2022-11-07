using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public int ProductColorId { get; set; }
        public int ProductSizeId { get; set; }
        public Category Category { get; set; }
        public ProductColor ProductColor { get; set; }
        public ProductSize ProductSize { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
