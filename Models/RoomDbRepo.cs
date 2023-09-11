namespace Parkview.Models
{
    public class RoomDbRepo : IRoomRepo
    {
        public void AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void GetAvailableRoom()
        {
            throw new NotImplementedException();
        }

        public void RemoveRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }


        private readonly ParkviewDbContext _parkviewDbContext;

        public RoomDbRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }
        public Room GetRoomById(int id)
        {
            return _parkviewDbContext.Rooms.Single(room => room.RoomId == id);
        }


        public IEnumerable<Room> GetRooms
        {
            get
            {
                return _parkviewDbContext.Rooms;
            }
        }


        public IEnumerable<Room> SearchRoomsByType(string searchQuery)
        {
            return _parkviewDbContext.Rooms.Where(room => room.RoomType == searchQuery);
        }
    }
}
