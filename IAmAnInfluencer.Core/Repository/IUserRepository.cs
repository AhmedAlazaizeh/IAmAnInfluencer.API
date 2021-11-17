using IAmAnInfluencer.Core.Data;
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
    }
}
