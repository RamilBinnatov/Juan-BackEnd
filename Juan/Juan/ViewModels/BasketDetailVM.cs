using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class BasketDetailVM
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }

    }
}
