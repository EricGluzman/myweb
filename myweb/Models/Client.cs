using System.ComponentModel.DataAnnotations;

namespace myweb.Models
{
    // A client of the car rental site. Every Client object = one row in the Clients table.
    public class Client
    {
        // "Id" is recognized automatically by EF Core as the primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a full name")]
        [StringLength(50)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Required(ErrorMessage = "Please enter an email")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; } = "";

        // The "?" means this field is optional (can be null in the database)
        [Phone]
        public string? Phone { get; set; }

        [Display(Name = "Join Date")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; } = DateTime.Now;
    }
}
