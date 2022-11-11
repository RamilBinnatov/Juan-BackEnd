using Juan.Data;
using Juan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductSizeController : Controller
    {
        private readonly AppDbContext _context;

        public ProductSizeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductSize> productSizes = await _context.ProductSizes
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            return View(productSizes);
        }




        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductSize productSize)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }


                bool isExist = await _context.ProductSizes.AnyAsync(m => m.Size.Trim() == productSize.Size.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("size", "size already exist");
                    return View();
                }


                await _context.ProductSizes.AddAsync(productSize);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            ProductSize productSize = await _context.ProductSizes.FindAsync(id);

            if (productSize == null) return NotFound();

            return View(productSize);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            ProductSize productSize = await _context.ProductSizes.FirstOrDefaultAsync(m => m.Id == id);

            productSize.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                ProductSize productSize = await _context.ProductSizes.FirstOrDefaultAsync(m => m.Id == id);

                if (productSize is null) return NotFound();

                return View(productSize);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductSize productSize)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(productSize);
                }

                ProductSize dbProductSize = await _context.ProductSizes.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

                if (dbProductSize is null) return NotFound();

                if (dbProductSize.Size.ToLower().Trim() == productSize.Size.ToLower().Trim())
                {
                    return RedirectToAction(nameof(Index));
                }

                //dbCategory.Name = category.Name;

                _context.ProductSizes.Update(productSize);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
