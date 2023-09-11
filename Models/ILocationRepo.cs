namespace Parkview.Models
{
    public interface ILocationRepo
    {
        public Location GetLocationById(int locationId);

        public IEnumerable<Location> GetLocations { get; }

        public IEnumerable<Location> SearchLocations(string searchQuery);
    }
}
