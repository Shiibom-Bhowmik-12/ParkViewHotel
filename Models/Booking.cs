using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace Parkview.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Please enter Guest Name")]
        [StringLength(30)]
        public string GuestName { get; set; }

        [Required(ErrorMessage = "Please enter Phone No")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, MinimumLength = 10)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number should be greater than zero")]
        public int NoOfAdults { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Number should be non-negative")]
        public int NoofChildrenUpto5 { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Number should be non-negative")]
        public int NoOfChildrenAbove5 { get; set; }

        [Required(ErrorMessage = "Enter the check-in Date")]
        [DataType(DataType.DateTime)]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Enter the check-out Date")]
        [DataType(DataType.DateTime)]
        public DateTime CheckOutDate { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public int RoomId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number should be greater than zero")]
        public int NoOfRooms { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public string? UserId { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal BookingTotal { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CheckOutDate <= CheckInDate)
            {
                yield return new ValidationResult("Check-out date must be after check-in date.", new[] { nameof(CheckOutDate) });
            }
        }
    }
}