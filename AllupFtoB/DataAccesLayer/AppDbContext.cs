using Microsoft.EntityFrameworkCore;

namespace AllupFtoB.DataAccesLayer.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<HelpDesk> HelpDesk { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Delivery> Deliveries  { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<VisitorCount> VisitorCounts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
    }
}
