namespace Parkview.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string? Name { get; set; }

        public int PhoneNumber { get; set; }

        public string? EmailAddress { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }
    }
}
