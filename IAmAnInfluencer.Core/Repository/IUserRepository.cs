using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IUserRepository
    {
        public bool addUser(User user);
        public List<User> getAllUser();
        public bool deleteUser(int ID);
        public bool updateUser(User user);
        public object countOfCustomers();
        public object countOfEmployees();
        public object countOfInfluncers();
        public List<User> customersList();
        public List<User> employeeList();
        public List<User> influncersList();
        public object getUser(int ID);
        public List<User> getUserByUsername(string username);
        public int getUserIDbyUsername(string username);
        public List<DeductionDTOResult> getFinancial();
        public bool update(int userID, string fName, string lName, string email, string phoneNumber, string username, string password, string longitude, string latitude, DateTime employmentDate, int roleID, double salary);
    }
}
