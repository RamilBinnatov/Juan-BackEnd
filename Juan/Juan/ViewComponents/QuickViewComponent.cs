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
    public class QuickViewComponent : ViewComponent
    {
        private readonly LayoutService _layoutService;
        private readonly AppDbContext _context;
        public QuickViewComponent(LayoutService layoutService, AppDbContext context)
        {
            _layoutService = layoutService;
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {
            Dictionary<string, string> settingDatas = await _layoutService.GetDatasFromSetting();


            Products product = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages)
                .Include(m => m.Category)
                .FirstOrDefaultAsync();
            IEnumerable<Social> socials = await _context.Socials
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            ProductDetailVM productDetailVM = new ProductDetailVM
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category.Name,
                ProductImages = product.ProductImages,
                ProductDiscount = product.Discount,
                socials = socials
            };

            return View(productDetailVM);

        }
    }
}
