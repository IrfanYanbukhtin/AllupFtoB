using AllupFtoB.DataAccesLayer.Entities;

namespace AllupFtoB.ViewModels
{
    public class HeaderViewModel
    {
        public List<Header> Headers { get; set; }
        public List<BasketViewModel> BasketViewModels { get; set; }
        public List<Product>? Products { get; set; }

    }
}
