using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Blog : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Quote { get; set; }
        public string Context { get; set; }
        public DateTime CreateDate { get; set; }
        public string Creator { get; set; }
    }
}
