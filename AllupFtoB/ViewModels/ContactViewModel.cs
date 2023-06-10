using AllupFtoB.DataAccesLayer.Entities;

namespace AllupFtoB.ViewModels
{
    public class ContactViewModel
    {
        public List<Contact>? Contacts { get; set; }
        public List<Delivery>? Deliveries { get; set; }
        public List<Brand>? Brands { get; set; }
    }
}
