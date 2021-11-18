using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IJWTService
    {
        public string Auth(LoginDTO loginDTO);
    }
}
