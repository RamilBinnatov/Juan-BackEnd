using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class PraductBanner : BaseEntity
    {
        public string Images { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
