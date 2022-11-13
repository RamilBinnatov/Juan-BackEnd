using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class BlogDetailVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Quote { get; set; }
        public string Context { get; set; }
        public DateTime CreateDate { get; set; }
        public string Creator { get; set; }
        public Blog Blog { get; set; }
        public IEnumerable<Blog> RecentBlogs { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Social> Socials { get; set; }
    }
}
