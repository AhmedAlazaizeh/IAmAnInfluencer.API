using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IRoleRepository
    {
        public bool addRole(Role role);
        public List<Role> getAllRole();
        public bool deleteRole(int ID);
        public bool updateRole(Role role);
    }
}
