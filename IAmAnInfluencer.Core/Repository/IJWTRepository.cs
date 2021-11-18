using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IJWTRepository
    {
        public LoginDTOResult Login(LoginDTO loginDTO);
    }
}
