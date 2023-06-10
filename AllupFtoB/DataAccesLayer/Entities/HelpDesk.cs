namespace AllupFtoB.DataAccesLayer.Entities
{
    public class HelpDesk : Entity
    {
        public string SupportDetail { get; set; }
        public string Detail_1 { get; set; }
        public string Detail_2 { get; set; }
        public string Detail_3 { get; set; }
        public string Detail_4 { get; set; }
        public string Detail_5 { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
        
    }
}
