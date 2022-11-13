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
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Products product = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages)
                .Include(m => m.Category)
                .FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Products> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .ToListAsync();

            if (product == null)
            {
                return NotFound();
            }

            ProductDetailVM productDetailVM = new ProductDetailVM
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category.Name,
                ProductImages = product.ProductImages,
                ProductDiscount = product.Discount,
                socials = socials,
                ProductsSlid = products
                
            };

            return View(productDetailVM);
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(Comment comment)
        {
           await _context.Comments.AddAsync(comment);
           await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = comment.ProductsId });
        }
    }
}
