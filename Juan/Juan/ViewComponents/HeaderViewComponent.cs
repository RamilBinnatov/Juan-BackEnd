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
    public class HeaderViewComponent : ViewComponent
    {
        private readonly LayoutService _layoutService;
        private readonly AppDbContext _context;

        public HeaderViewComponent(LayoutService layoutService, AppDbContext context)
        {
            _layoutService = layoutService;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settingDatas = await _layoutService.GetDatasFromSetting();

            IEnumerable<Currency> currencies = await _context.Currencies
                .Where(m=>!m.IsDeleted)
                .ToListAsync();
            IEnumerable<Language> languages = await _context.Languages
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            HeaderVM headerVM = new HeaderVM
            {
                Currencies = currencies,
                Languages = languages,

            };

            return await Task.FromResult(View(headerVM));
        }
    }
}
