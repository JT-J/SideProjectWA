using Microsoft.EntityFrameworkCore;
using SideProjectWA.Models;

namespace SideProjectWA;


public class UserContext : DbContext
    {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }

    public DbSet<UserModel>
        Users { get; set; }
    }
