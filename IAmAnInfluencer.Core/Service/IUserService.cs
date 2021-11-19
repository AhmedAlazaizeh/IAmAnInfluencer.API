using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IUserService
    {
        public bool addUser(User user);
        public List<User> getAllUser();
        public bool deleteUser(int ID);
        public bool updateUser(User user);
        public int countOfCustomers();
        public int countOfEmployees();
        public int countOfInfluncers();
        public List<User> customersList();
        public List<User> employeeList();
        public List<User> influncersList();
    }
}
