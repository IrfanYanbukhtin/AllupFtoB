using AllupFtoB.DataAccesLayer.Entities;

namespace AllupFtoB.ViewModels
{
    public class ProductViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Delivery>? Deliveries { get; set; }
        public List<Brand>? Brands { get; set; }
    }
}
