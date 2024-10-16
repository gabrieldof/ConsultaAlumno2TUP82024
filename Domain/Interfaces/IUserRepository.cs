using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        //List<User> GetAll();
        //public User GetById(int id);

        public User Add(User user);

        public User Update(User user);

    }
}
