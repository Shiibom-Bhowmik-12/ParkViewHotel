using System.Security.Policy;

namespace Parkview.Models
{
    public class DestinationDbRepo : IDestinationRepo
    {
        private readonly ParkviewDbContext _parkviewDbContext;


        public DestinationDbRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }

        //get destination list
        public IEnumerable<Destination> GetDestinationList
        {
            get
            {
                return _parkviewDbContext.Destinations;
            }
        }

        //get total destinations
        public int TotalDestinations
        {
            get
            {
                return _parkviewDbContext.Destinations.Count();
            }
        }

        //get destination by id
        public Destination GetDestinationById(int destinationId)
        {
            return _parkviewDbContext.Destinations.FirstOrDefault(d => d.DestinationId == destinationId);
        }




        public IEnumerable<Destination> SearchDestination(string name)
        {
            return _parkviewDbContext.Destinations.Where(dest => dest.DestinationName.Contains(name));
        }



        public IEnumerable<Destination> ListOfDestinationsByHotelChain(int id)
        {
            return _parkviewDbContext.Destinations.Where(dest => dest.HotelChainId == id);
        }

    }
}
