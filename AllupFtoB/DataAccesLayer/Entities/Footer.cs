namespace AllupFtoB.DataAccesLayer.Entities
{
    public class Footer : Entity
    {
        public string CreatedBy { get; set; }
        public string CardImageUrl  { get; set;}
        public ICollection<HelpDesk> HelpDesks { get; set;}
    }
}
