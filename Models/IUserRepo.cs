using Microsoft.AspNetCore.Identity;

namespace Parkview.Models
{
    public interface IUserRepo
    {
        public IdentityUser GetUser(string userId);
    }
}
