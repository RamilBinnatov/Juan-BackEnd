using Juan.Data;
using Juan.Models;
using Juan.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;
        public ContactController(AppDbContext context, LayoutService layoutService)
        {
            _context = context;
            _layoutService = layoutService;
        }
        public async Task<IActionResult> Index()
        {
            Dictionary<string, string> settingDatas = await _layoutService.GetDatasFromSetting();
            string Address = settingDatas["Address"];
            string PhoneNumber = settingDatas["PhoneNumber"];
            string WorkingHours = settingDatas["WorkingHours"];
            string Email = settingDatas["Email"];

            ViewBag.Address = Address;
            ViewBag.PhoneNumber = PhoneNumber;
            ViewBag.WorkingHours = WorkingHours;
            ViewBag.Email = Email;  
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }
    }
}
