using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using SideProjectWA.Models;

namespace SideProjectWA.Services
{
    public interface IUserService
    {
        Task SaveUserAsync(UserModel user);
    }
}
