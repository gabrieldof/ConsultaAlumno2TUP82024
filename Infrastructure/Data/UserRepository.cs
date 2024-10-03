using Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository (ApplicationDbContext context)
        {
            _context = context;
        }


        public List<User> GetAll() 
        { 
            return _context.Users.ToList(); 
        }


        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }


        public User Update(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
