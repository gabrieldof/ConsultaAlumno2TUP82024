using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISubjectService 
    {
        public List<Subject> GetAll();
        public Subject? GetById(int id);
        //public Subject Add(UserForAddRequest userDtoRequest);

        //public Subject Update(int id, UserForUpdateRequest userDtoUpdateRequest);
    }
}
