using AllupFtoB.DataAccesLayer.Entities;

namespace AllupFtoB.ViewModels
{
    public class HomeViewModel
    {
        public List<Product>? Products { get; set; }
        public List<SliderImage>? SliderImages { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Delivery>? Deliveries { get; set; }
        public List<Brand>? Brands { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<VisitorCount> VisitorCounts { get; set; }
    }
}
