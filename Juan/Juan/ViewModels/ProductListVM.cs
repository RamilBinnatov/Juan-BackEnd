using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string MainImage { get; set; }
    }
}
