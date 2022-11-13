using Juan.Data;
using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly AppDbContext _context;

        public BlogDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Blog blog = await _context.Blogs
                .Where(m => !m.IsDeleted && m.Id == id)
                .FirstOrDefaultAsync();
            IEnumerable<Category> categories = await _context.Categories
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Tags> tags = await _context.Tags
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Social> socials = await _context.Socials
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Blog> recentPost = await _context.Blogs
                .Where(m => !m.IsDeleted)
                .OrderByDescending(m => m.Id)
                .Take(4)
                .ToListAsync();

            if (blog == null)
            {
                return NotFound();
            }

            BlogDetailVM blogDetail = new BlogDetailVM
            {
                Id = blog.Id,
                Title = blog.Title,
                Intro = blog.Intro,
                Quote = blog.Quote,
                Context = blog.Context,
                Categories = categories,
                Tags = tags,
                CreateDate = blog.CreateDate,
                Creator = blog.Creator,
                Image = blog.Image,
                Socials = socials,
                RecentBlogs = recentPost,
            };





            return View(blogDetail);
        }
    }
}
