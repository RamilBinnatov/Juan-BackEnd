using Juan.Data;
using Juan.Models;
using Juan.Services;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;

        public BlogController(AppDbContext context, LayoutService layoutService )

        {
            _context = context;
            _layoutService = layoutService;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _context.Blogs
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Blog> recentPost = await _context.Blogs
                .Where(m => !m.IsDeleted)
                .OrderByDescending(m=>m.Id)
                .Take(4)
                .ToListAsync();
            IEnumerable<Category> categories = await _context.Categories
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Tags> tags = await _context.Tags.Where(m => !m.IsDeleted).ToListAsync();

            BlogVM model = new BlogVM
            {
                Blogs = blogs,
                RecentPost = recentPost,
                Categories = categories,
            };

            return View(model);
        }
    }
}
