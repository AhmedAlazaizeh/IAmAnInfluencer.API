using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository _roleRepository)
        {
            roleRepository = _roleRepository;
        }

        public bool addRole(Role role)
        {
            return roleRepository.addRole(role);
        }

        public bool deleteRole(int ID)
        {
            return roleRepository.deleteRole(ID);
        }

        public List<Role> getAllRole()
        {
            return roleRepository.getAllRole();
        }

        public bool updateRole(Role role)
        {
            return roleRepository.updateRole(role);
        }
    }
}
