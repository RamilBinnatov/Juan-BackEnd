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

            Product product = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages)
                .Include(m => m.Category)
                .Include(m => m.ProductColor)
                .Include(m =>m.ProductSize)
                .FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            if (product == null)
            {
                return NotFound();
            }

            ProductDetailVM productDetailVM = new ProductDetailVM
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category.Name,
                ProductColor = product.ProductColor.Color,
                ProductSize = product.ProductSize.Size,
                productImages = product.ProductImages,
                ProductDiscount = product.Discount,
                socials = socials,
            };


            return View(productDetailVM);
        }
    }
}
