using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SubjectService : ISubjectService   
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public List<Subject> GetAll()
        {
            return _subjectRepository.GetAll();
        }
        public Subject? GetById(int id)
        {
            return _subjectRepository.GetById(id);
        }

        //public User Add(UserForAddRequest userDtoRequest)
        //{
        //    var user = new User()
        //    {
        //        Name = userDtoRequest.Name,
        //        LastName = userDtoRequest.LastName,
        //        Password = userDtoRequest.Password,
        //        Email = userDtoRequest.Email,
        //        UserName = userDtoRequest.UserName,
        //        UserType = userDtoRequest.UserType


        //    };

        //    return _userRepository.Add(user);
        //}


        //public User Update(int id, UserForUpdateRequest userDtoRequest)
        //{

        //    var user = _userRepository.GetById(id);



        //    user.Name = userDtoRequest.Name;
        //    user.LastName = userDtoRequest.LastName;
        //    user.Password = userDtoRequest.Password;
        //    user.Email = userDtoRequest.Email;
        //    user.UserName = userDtoRequest.UserName;
        //    user.UserType = userDtoRequest.UserType;



        //    return _userRepository.Update(user);
        //}
    }
}
