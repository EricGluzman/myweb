namespace myweb.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime BidDate { get; set; } = DateTime.Now;

        public int ClientId { get; set; }
        public Client? Client { get; set; } 
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
