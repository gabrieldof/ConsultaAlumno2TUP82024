using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        public List<User> GetAll()
        {
            return new List<User> {
                                        new User { Id=1, Name= "Gabriel", LastName="Furrer", Password="1234", Email="hola@gmail.com" },
                                        new User { Id=2, Name= "Carlos", LastName="Perez", Password="1234", Email="hola@gmail.com" },
                                         new User { Id=3, Name= "Pedro", LastName="Rodriguez", Password="1234", Email="hola@gmail.com" }
            };
        }
    }
}
