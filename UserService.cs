using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SideProjectWA.Models;

namespace SideProjectWA.Services
{
    public class UserService : IUserService
    {
        private readonly UserContext _context;

        public UserService(UserContext context)
        {
            _context = context;
        }

        public async Task SaveUserAsync(UserModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
