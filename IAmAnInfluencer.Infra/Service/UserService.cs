using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
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

        public bool addUser(addUserDTO addUserDTO)
        {
            return userRepository.addUser(addUserDTO);
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

        public object countOfCustomers()
        {
            return userRepository.countOfCustomers();
        }

        public object countOfEmployees()
        {
            return userRepository.countOfEmployees();
        }

        public object countOfInfluncers()
        {
            return userRepository.countOfInfluncers();
        }

        public List<User> customersList()
        {
            return userRepository.customersList();
        }

        public List<employeeListDTOResult> employeeList()
        {
            return userRepository.employeeList();
        }

        public List<User> influncersList()
        {
            return userRepository.influncersList();
        }

        public List<User> getUser(int ID)
        {
            return userRepository.getUser(ID);
        }

        public List<User> getUserByUsername(string username)
        {
            return userRepository.getUserByUsername(username);
        }

        public int getUserIDbyUsername(string username)
        {
            return userRepository.getUserIDbyUsername(username);
        }
        public List<DeductionDTOResult> getFinancial()
        {
            return userRepository.getFinancial();
        }

        public bool update(int userID, string fName, string lName, string email, string phoneNumber, string username, string password, string longitude, string latitude, DateTime employmentDate, int roleID, double salary)
        {
            return userRepository.update(userID, fName, lName, email, phoneNumber, username, password, longitude, latitude, employmentDate, roleID, salary);
        }
    }

}
