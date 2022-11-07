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
    public class FooterViewComponent : ViewComponent
    {
        private readonly LayoutService _layoutService;
        private readonly AppDbContext _context;

        public FooterViewComponent(LayoutService layoutService, AppDbContext context)
        {
            _layoutService = layoutService;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settingDatas = await _layoutService.GetDatasFromSetting();

            string email = settingDatas["Email"];

            IEnumerable<Social> socials = await _context.Socials
                .Where(m => !m.IsDeleted)?
                .ToListAsync();


            FooterVM footerVM = new FooterVM
            {
                Socials = socials,
            };



            return await Task.FromResult(View(footerVM));
        }
    }
}
