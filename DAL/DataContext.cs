using Microsoft.EntityFrameworkCore;
using WebProject.Models;

namespace WebProject.DAL
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<UsersInfo> usersinfo { get; set; }
        
       
    }
}
