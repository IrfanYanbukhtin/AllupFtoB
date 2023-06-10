using AllupFtoB.DataAccesLayer;
using AllupFtoB.DataAccesLayer.Entities;
using AllupFtoB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Drawing2D;

namespace AllupFtoB.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var contact = _dbContext.Contacts.ToList();
            var delivery = _dbContext.Deliveries.ToList();
            var brand = _dbContext.Brands.ToList();

            var viewModel = new ContactViewModel
            {
                Contacts = contact,
                Deliveries = delivery,
                Brands = brand,
            };

            return View(viewModel);
        }
    }
}
