using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class BlogVM
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Blog> RecentPost { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tags> Tags { get; set; }




    }
}
