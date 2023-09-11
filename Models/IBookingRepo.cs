namespace Parkview.Models
{
    public interface IBookingRepo
    {
        public IEnumerable<Booking> GetAllBookings { get; }
        public Booking GetBooking(int id);
        public void SubmitBooking(Booking booking);

        public IEnumerable<Booking> BookingListByUser(string userId);

        public void CancelBooking(int id);
    }
}
