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
        private readonly ProductService _productService;

        public ShopController(AppDbContext context, ProductService productService, LayoutService layoutService)
        {
            _context = context;
            _layoutService = layoutService;
            _productService = productService;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 4)
        {
            Dictionary<string, string> settingDatas = await _layoutService.GetDatasFromSetting();
            string Ad = settingDatas["ShopAd"];

            ViewBag.Ad = Ad;

            IEnumerable<Category> categories = await _context.Categories
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<ProductColor> productColors = await _context.ProductColors
                .Where(m => !m.IsDeleted)  
                .ToListAsync();
            IEnumerable<ProductSize> productSize = await _context.ProductSizes
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Products> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m => m.Category)
                .Include(m => m.ProductImages)
                .ToListAsync();


            ShopVM model = new ShopVM
            {
                Categories = categories,
                ProductColors = productColors,
                ProductSizes = productSize,
                Products = products,

                
            };


            return View(model);
        }
    }
}
