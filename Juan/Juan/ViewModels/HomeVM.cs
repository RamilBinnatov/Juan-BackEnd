using Juan.Models;
using System.Collections.Generic;

namespace Juan.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<PraductBanner> PraductBanners { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
