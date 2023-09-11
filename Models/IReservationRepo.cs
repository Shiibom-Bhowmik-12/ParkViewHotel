namespace Parkview.Models
{
    public interface IReservationRepo
    {

        //get
        public Reservation GetReservation(int reservationId);

        public bool BookReservation(Reservation reservation);


    }
}
