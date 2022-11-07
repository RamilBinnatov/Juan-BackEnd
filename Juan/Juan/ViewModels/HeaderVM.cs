using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class HeaderVM
    {
        public IEnumerable<Currency> Currencies { get; set; }
        public IEnumerable<Language> Languages { get; set; }
    }
}
