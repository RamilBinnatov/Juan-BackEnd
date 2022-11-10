using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<ProductColor> ProductColors { get; set; }
        public IEnumerable<ProductSize> ProductSizes { get; set; }
        public Advertisement Advertisements { get; set; }



    }
}
