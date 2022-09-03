using DotNet5_Store.Domain.Entities.Users;
using DotNet5_Store_Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DotNet5_Store_Persistance.Contexts
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRoll> UserInRolls { get; set; }
    }
}