using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Comment : BaseEntity
    {
        public string CommentDetail { get; set; }
        public Products Products { get; set; }
        public int ProductsId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime AddingTime { get; set; }
    }
}
