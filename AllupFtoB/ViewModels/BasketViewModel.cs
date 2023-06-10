using AllupFtoB.DataAccesLayer.Entities;

namespace AllupFtoB.ViewModels
{
    public class BasketViewModel 
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public int Count { get; set; }
    }
}
