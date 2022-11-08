using Juan.Data;
using Juan.Models;
using Juan.Services;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;
        public HomeController(AppDbContext context, LayoutService layoutService)
        {
            _context = context;
            _layoutService = layoutService;
        }



        public async Task<IActionResult> Index()
        {


            Dictionary<string, string> settingDatas = await _layoutService.GetDatasFromSetting();

            int homeTakeProduct = int.Parse(settingDatas["HomeTakeProduct"]);

            IEnumerable<Slider> sliders = await _context.Sliders
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<PraductBanner> praductBanners = await _context.PraductBanners
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Service> services = await _context.Services
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Category> categories = await _context.Categories
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Blog> blogs = await _context.Blogs
                .Where(m => !m.IsDeleted)
                .Take(4)
                .ToListAsync();
            IEnumerable<Brand> brands = await _context.Brands
                .Where(m => !m.IsDeleted)
                .ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => m.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.ProductImages)
                .Take(homeTakeProduct)
                .ToListAsync();
                

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                Services = services,
                Categories = categories,
                Products = products,
                PraductBanners = praductBanners,
                Blogs = blogs,
                Brands = brands,
            };

            return View(model);
        }


        //[HttpPost]
        //public async Task<IActionResult> AddBasket(int? id)
        //{
        //    if (id is null) return BadRequest();

        //    var dbProduct = await GetProductById(id);

        //    if (dbProduct == null) return NotFound();

        //    List<BasketVM> basket = GetBasket();

        //    UpdateBasket(basket, dbProduct.Id);

        //    Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

        //    return Ok();
        //}


        //private void UpdateBasket(List<BasketVM> basket, int id)
        //{
        //    BasketVM existProduct = basket.FirstOrDefault(m => m.Id == id);

        //    if (existProduct == null)
        //    {
        //        basket.Add(new BasketVM
        //        {
        //            Id = id,
        //            Count = 1
        //        });
        //    }
        //    else
        //    {
        //        existProduct.Count++;
        //    }
        //}

        //private async Task<Product> GetProductById(int? id)
        //{
        //    return await _context.Products.FindAsync(id);
        //}


        //private List<BasketVM> GetBasket()
        //{
        //    List<BasketVM> basket;

        //    if (Request.Cookies["basket"] != null)
        //    {
        //        basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
        //    }
        //    else
        //    {
        //        basket = new List<BasketVM>();
        //    }

        //    return basket;
        //}


    }
}
