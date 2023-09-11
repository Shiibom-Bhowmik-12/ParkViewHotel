namespace Parkview.Models
{
    public interface IRoomRepo
    {
        //add room
        public void AddRoom(Room room);

        //remove room
        public void RemoveRoom(Room room);

        //update room
        public void UpdateRoom(Room room);

        //delete room
        public void DeleteRoom(Room room);

        //get all available room
        public void GetAvailableRoom();

        public IEnumerable<Room> GetRooms { get; }

        public Room GetRoomById(int id);
    }
}
