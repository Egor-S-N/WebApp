using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;
using WebProject.DAL;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Repositories.ForUsersInfo
{
    public class InfoRepository : IInfoRepository
    {
        private readonly IDataContext _context;
        public InfoRepository(IDataContext context)
        {
            _context = context;
        }
        public async Task Add(UsersInfo info)
        {
            _context.usersinfo.Add(info);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var item = await _context.usersinfo.FindAsync(id);
            if (item == null)
            {
                throw new NullReferenceException();
            }
            _context.usersinfo.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<UsersInfo> Get(int id)
        {
            return await _context.usersinfo.FindAsync(id);
        }

        public async Task<IEnumerable<UsersInfo>> GetAll()
        {
            return await _context.usersinfo.ToListAsync();
        }

        public async Task Update(UsersInfo info)
        {
            var item = await _context.usersinfo.FindAsync(info.id);
            if (item == null)
            {
                throw new NullReferenceException();
            }
            item.lastname = info.lastname;
            item.dob = info.dob;
            item.age = info.age;

            await _context.SaveChangesAsync();
        }
    }
}
