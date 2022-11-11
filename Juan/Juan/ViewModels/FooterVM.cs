using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class FooterVM
    {
        public IEnumerable<Social> Socials { get; set; }
        public List<BasketDetailVM> BasketProduct { get; set; }
    }
}
