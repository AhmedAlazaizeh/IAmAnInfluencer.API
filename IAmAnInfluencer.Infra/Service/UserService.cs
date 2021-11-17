using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public bool addUser(User user)
        {
            return userRepository.addUser(user);
        }

        public bool deleteUser(int ID)
        {
            return userRepository.deleteUser(ID);
        }

        public List<User> getAllUser()
        {
            return userRepository.getAllUser();
        }

        public bool updateUser(User user)
        {
            return userRepository.updateUser(user);
        }
    }
}
