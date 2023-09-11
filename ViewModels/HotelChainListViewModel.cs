using Parkview.Models;

namespace Parkview.ViewModels
{
    public class HotelChainListViewModel
    {
        public HotelChain HotelChain;

        public IEnumerable<Hotel> Hotels { get; set; }

        public IEnumerable<Destination> Destinations { get; set; }

        public HotelChainListViewModel(HotelChain hchain, IEnumerable<Hotel> hotels, IEnumerable<Destination> destinations)
        {
            HotelChain = hchain;
            Hotels = hotels;
            Destinations = destinations;
        }
    }
}
