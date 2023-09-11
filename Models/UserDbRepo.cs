using Microsoft.AspNetCore.Identity;

namespace Parkview.Models
{
    public class UserDbRepo : IUserRepo
    {
        private readonly ParkviewDbContext _parkviewDbContext;
        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDbRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }

        public IdentityUser GetUser(string userId)
        {
            return _parkviewDbContext.Users.FirstOrDefault(user => user.Id == userId);
        }
    }
}
