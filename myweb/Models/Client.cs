using System.ComponentModel.DataAnnotations;

namespace myweb.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string? Phone { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.Now;

        public List<Bid> Bids { get; set; } = new();

    }
}
