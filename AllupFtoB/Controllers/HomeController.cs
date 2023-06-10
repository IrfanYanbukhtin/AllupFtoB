using AllupFtoB.DataAccesLayer.Entities;
using AllupFtoB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AllupFtoB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var product = await _dbContext.Products.ToListAsync();
            var sliderImage  = await _dbContext.SliderImages.ToListAsync();
            var banners = await _dbContext.Banners.ToListAsync();
            var delivery = await _dbContext.Deliveries.ToListAsync();
            var brand = await _dbContext.Brands.ToListAsync();
            var testimonial = await _dbContext.Testimonials.ToListAsync();

            var model = new HomeViewModel
            {
                Products = product,
                SliderImages = sliderImage,
                Banners = banners,
                Deliveries = delivery,
                Brands = brand,
                Testimonials = testimonial,
            };          

            return View(model);
        }

        public IActionResult Basket()
        {
            var json = Request.Cookies["basket"];

            List<BasketViewModel> basketViewModels;

            if (json == null) basketViewModels = new List<BasketViewModel>();
            else basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(json);

            return Json(basketViewModels);
        }

        public IActionResult AddToBasket(int? id)
        {
            if (id == null) return NotFound();

            var product = _dbContext.Products.Find(id);

            var json = Request.Cookies["basket"];
            List<BasketViewModel> basketViewModels;

            if (json == null) basketViewModels = new List<BasketViewModel>();
            else basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(json);

            if (basketViewModels == null)
            {
                basketViewModels = new List<BasketViewModel>();
                basketViewModels.Add(new BasketViewModel
                {
                    ProductId = product.Id,
                    Title = product.Title,
                    Price = product.Price
                });
            }
            else
            {
                var existBasketViewModel = basketViewModels.FirstOrDefault(x => x.ProductId == product.Id);

                if (existBasketViewModel == null)
                {
                    basketViewModels.Add(new BasketViewModel
                    {
                        ProductId = product.Id,
                        Title = product.Title,
                        Price = product.Price,
                        ImageUrl = product.ImageUrl,
                    });
                }

                else
                {
                    existBasketViewModel.Count++;
                }
            }

            json = JsonConvert.SerializeObject(basketViewModels);

            Response.Cookies.Append("basket", json);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search(string searchedProduct)
        {
            if (string.IsNullOrEmpty(searchedProduct)) return NoContent();

            var products = _dbContext.Products.Where(x => x.Title.Contains(searchedProduct)).ToList();

            return PartialView("_SearchedProductPartial", products);
        }


    }
}