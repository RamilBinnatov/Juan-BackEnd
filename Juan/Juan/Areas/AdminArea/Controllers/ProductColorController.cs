using Juan.Data;
using Juan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class ProductColorController : Controller
    {
        private readonly AppDbContext _context;

        public ProductColorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductColor> productColors = await _context.ProductColors
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            return View(productColors);
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductColor productColor)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }


                bool isExist = await _context.ProductColors.AnyAsync(m => m.Color.Trim() == productColor.Color.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("Name", "Colour already exist");
                    return View();
                }


                await _context.ProductColors.AddAsync(productColor);

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

            ProductColor productColor = await _context.ProductColors.FindAsync(id);

            if (productColor == null) return NotFound();

            return View(productColor);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            ProductColor productColor = await _context.ProductColors.FirstOrDefaultAsync(m => m.Id == id);

            productColor.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                ProductColor productColor = await _context.ProductColors.FirstOrDefaultAsync(m => m.Id == id);

                if (productColor is null) return NotFound();

                return View(productColor);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductColor productColor)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(productColor);
                }

                ProductColor dbProductColor = await _context.ProductColors.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

                if (dbProductColor is null) return NotFound();

                if (dbProductColor.Color.ToLower().Trim() == productColor.Color.ToLower().Trim())
                {
                    return RedirectToAction(nameof(Index));
                }

                //dbCategory.Name = category.Name;

                _context.ProductColors.Update(productColor);

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
