namespace Parkview.Models
{
    public interface IDestinationRepo
    {
        public IEnumerable<Destination> GetDestinationList { get; }

        public int TotalDestinations { get; }

        public Destination GetDestinationById(int destinationId);


        public IEnumerable<Destination> ListOfDestinationsByHotelChain(int id);

        public IEnumerable<Destination> SearchDestination(string searchQuery);

    }
}
