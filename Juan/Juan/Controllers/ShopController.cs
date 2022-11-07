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
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;

        public ShopController(AppDbContext context, LayoutService layoutService)
        {
            _context = context;
            _layoutService = layoutService;
        }

        public async Task<IActionResult> Index()
        {
            Dictionary<string, string> settingDatas = await _layoutService.GetDatasFromSetting();

            IEnumerable<Category> categories = await _context.Categories
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<ProductColor> productColors = await _context.ProductColors
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<ProductSize> productSize = await _context.ProductSizes
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => m.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.ProductImages)
                .ToListAsync();
            Advertisement advertisements = await _context.Advertisements
                .Where(m => !m.IsDeleted)
                .FirstOrDefaultAsync();

            ShopVM model = new ShopVM
            {
                Categories = categories,
                ProductColors = productColors,
                ProductSizes = productSize,
                Products = products,
                Advertisements = advertisements,
            };


            return View(model);
        }
    }
}
