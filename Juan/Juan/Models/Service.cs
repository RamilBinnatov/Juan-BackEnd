using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Service : BaseEntity
    {
        public string Title { get; set; }
        public string Descrption { get; set; }
        public string Image { get; set; }
    }
}
