using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        public List<User> GetAll();
        public User GetById(int id);

        public User Add(UserForAddRequest userDtoRequest);

        public User Update(int id, UserForUpdateRequest userDtoUpdateRequest);
    }
}
