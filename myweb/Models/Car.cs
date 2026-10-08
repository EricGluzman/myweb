namespace myweb.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }

        public List<Bid> Bids { get; set; } = new();
        public List<Feature> Features { get; set; } = new();   

    }
}
