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

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            return existingUser != null;
        }

        public async Task RegisterUserAsync(UserModel user)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == user.Username);

            if (existingUser == null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new SystemException("Username already exists");
            }
        }
    }
}
