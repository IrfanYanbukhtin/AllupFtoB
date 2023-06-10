using AllupFtoB.DataAccesLayer.Entities;
using AllupFtoB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllupFtoB.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footer = await _dbContext.Footer.ToListAsync();
            var helpDesk = await _dbContext.HelpDesk.ToListAsync();

            var model = new FooterViewModel
            {
                Footers = footer,
                HelpDesks = helpDesk,
            };

            return View(model);
        }
    }
}
