using AllupFtoB.DataAccesLayer.Entities;
using AllupFtoB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AllupFtoB.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headers = await _dbContext.Headers.ToListAsync();
            var product = await _dbContext.Products.ToListAsync();

            var model = new HeaderViewModel
            {
                Headers = headers,
                Products = product,
            };

            return View(model);
        }
    }
}
