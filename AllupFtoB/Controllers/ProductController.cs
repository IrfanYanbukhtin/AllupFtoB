using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllupFtoB.DataAccesLayer.Entities;
using AllupFtoB.ViewModels;
using System.Drawing.Drawing2D;
using System;
using Newtonsoft.Json;

namespace AllupFtoB.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ProductController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var product = _dbContext.Products.Take(8).ToList();
            var delivery = _dbContext.Deliveries.ToList();
            var brand = _dbContext.Brands.ToList();

            var productviewModel = new ProductViewModel
            {
                Products = product,
                Deliveries = delivery,
                Brands = brand,
            };

            return View(productviewModel);
        }   

     
    }
}
