using Juan.Data;
using Juan.Helpers;
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
        public async Task <IActionResult> Index( int page = 1, int take = 6)
        {
            List<Blog> blogs = await _context.Blogs
                .Where(m => !m.IsDeleted)
                .Skip((page * take)-take)
                .Take(take)
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

            ViewBag.take = take;


            List<BlogVM> blogVMs = new List<BlogVM>();

            BlogVM model = new BlogVM
            {
                Blogs = blogs.ToList(),
                RecentPost = recentPost,
                Categories = categories,
                Tags = tags,
            };

            blogVMs.Add(model);

            int count = await GetPageCount(take);

            Paginate<BlogVM> result = new Paginate<BlogVM>(blogVMs, page, count);

            return View(result);
        }
        public async Task<int> GetPageCount(int take)
        {
            int blogCount = await _context.Blogs.Where(m => !m.IsDeleted).CountAsync();
            return (int)Math.Ceiling((decimal)blogCount / take);

        }
    }
}
