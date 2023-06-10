using AllupFtoB.DataAccesLayer.Entities;
using AllupFtoB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;


namespace AllupFtoB.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public BasketViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var json = Request.Cookies["basket"];

            List<BasketViewModel> basketViewModels;

            if (json == null) basketViewModels = new List<BasketViewModel>();
            else basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(json);

            return View(basketViewModels);
        }

    }
}
