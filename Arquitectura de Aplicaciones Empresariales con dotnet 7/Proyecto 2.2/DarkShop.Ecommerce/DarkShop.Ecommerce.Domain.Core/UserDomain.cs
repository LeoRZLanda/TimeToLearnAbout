using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Infrastructure.Interface;

namespace DarkShop.Ecommerce.Domain.Core
{
    public class UserDomain : IUserDomain
    {
        private readonly IUserRepository _userRepository;

        public UserDomain(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public User Authenticate(string username, string password) {
            return _userRepository.Authenticate(username, password);
        }
    }
}
