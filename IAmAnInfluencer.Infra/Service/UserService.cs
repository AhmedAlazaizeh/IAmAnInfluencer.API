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

        public int countOfCustomers()
        {
            return userRepository.countOfCustomers();
        }

        public int countOfEmployees()
        {
            return userRepository.countOfEmployees();
        }

        public int countOfInfluncers()
        {
            return userRepository.countOfInfluncers();
        }

        public List<User> customersList()
        {
            return userRepository.customersList();
        }

        public List<User> employeeList()
        {
            return userRepository.employeeList();
        }

        public List<User> influncersList()
        {
            return userRepository.influncersList();
        }
    }

}
