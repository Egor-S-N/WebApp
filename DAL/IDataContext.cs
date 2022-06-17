using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WebProject.DAL
{
    public interface IDataContext
    {
         DbSet<User> users { get; set; }
         DbSet<UsersInfo> usersinfo { get; set; }
         Task<int> SaveChangesAsync(CancellationToken cancellationToken = default); 
    }
}
