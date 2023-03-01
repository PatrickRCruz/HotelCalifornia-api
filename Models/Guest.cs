using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelCalifornia.API.Models
{
    [Table ("Guests")]
    public class Guest
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(90)]
        public string Email  { get; set; }
        public string Address { get; set; }
        public string Cpf { get; set; }
        public string CellNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
    }
}
