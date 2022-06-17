using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Repositories.ForUsersInfo
{
    public interface IInfoRepository
    {
        Task<UsersInfo> Get(int id);
        Task<IEnumerable<UsersInfo>> GetAll();
        Task Add(UsersInfo info);
        Task Delete(int id);
        Task Update(UsersInfo info);
    }
}
