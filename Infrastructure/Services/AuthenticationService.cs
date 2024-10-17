using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthenticationService : ICustomAuthenticationService
    {

        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        private User? ValidateUser(AuthenticationRequest authenticationRequest)
        {
            if (string.IsNullOrEmpty(authenticationRequest.UserName) || string.IsNullOrEmpty(authenticationRequest.Password))
                return null;

            var user = _userRepository.GetUserByUserName(authenticationRequest.UserName);
            if (user == null) return null;

            if (user.Password == authenticationRequest.Password) return user;

            return null;

        }

        public string Authenticate(AuthenticationRequest authenticationRequest)

        {
            var user = ValidateUser(authenticationRequest);

            //if (user == null)
            //{
            //    throw new NotAllowedException("User authentication failed");
            //}




            return "token";
        }


    }
}
