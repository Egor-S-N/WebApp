using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;
using WebProject.DAL;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Repositories.ForUsers
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataContext _context;
        public UserRepository(IDataContext context)
        {
            _context = context;
        }
        public async Task Add(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var item = await _context.users.FindAsync(id);
            if (item == null)
            {
                throw new NullReferenceException();
            }
            _context.users.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _context.users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.users.ToListAsync();
        }

        public async Task Update(User user)
        {
            var item = await _context.users.FindAsync(user.userid);
            if (item == null)
            {
                throw new NullReferenceException();
            }
            item.name = user.name;

            await _context.SaveChangesAsync();
        }
    }
}
