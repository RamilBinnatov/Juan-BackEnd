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

namespace Juan.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public CommentViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Comment> comments = await _context.Comments.Where(m => !m.IsDeleted).ToListAsync();

            return View(comments);
        }
    }       
 }

