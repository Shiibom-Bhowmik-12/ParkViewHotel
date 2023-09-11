using Parkview.Models;

namespace Parkview.ViewModels
{
    public class DestinationListViewModel
    {
        public IEnumerable<Destination> Destinations { get; set; }

        public int Size { get; set; }

        public DestinationListViewModel(IEnumerable<Destination> destinations, int size)
        {
            Destinations = destinations;
            Size = size;
        }
    }
}
