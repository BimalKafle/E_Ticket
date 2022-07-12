using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Repository
{
    public interface UserRepositoryInterface
    {
        public Task Insert(User user);
        public Task Update(User user);
        public Task<User?> GetById(long Id);
        public Task<IEnumerable<User>> GetAll();

        public Task Remove(User user);
    }
}
