namespace Parkview.Models
{
    public class LocationDpRepo : ILocationRepo
    {
        //public void AddLocation(Location location)
        //{
        //    throw new NotImplementedException();
        //}

        //public Location GetLocation(int locationId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveLocation(Location location)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateLocation(Location location)
        //{
        //    throw new NotImplementedException();
        //}



        private readonly ParkviewDbContext _parkviewDbContext;



        public LocationDpRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }
        public IEnumerable<Location> GetLocations => _parkviewDbContext.Locations;



        public Location GetLocationById(int locationId)
        {
            return _parkviewDbContext.Locations.Find(locationId);
        }



        public IEnumerable<Location> SearchLocations(string searchQuery)
        {
            return _parkviewDbContext.Locations.Where(loc => loc.Name.Contains(searchQuery));
        }
    }
}
