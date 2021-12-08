using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class JWTService: IJWTService
    {
        private readonly IJWTRepository jWTRepository;

        public JWTService(IJWTRepository _jWTRepository)
        {
            jWTRepository = _jWTRepository;
        }

        public DateTime Expires { get; private set; }

        public string Auth(LoginDTO loginDTO)
        {
            var result = jWTRepository.Login(loginDTO);
            if (result == null)
            {
                return null;
            }
            else
            {
                // 1- token handeler: generate token

                var tokenHandler = new JwtSecurityTokenHandler();

                // 2- token key: encryption key 

                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");

                // 3- token descriptor: username, password, role, session timout, (signcredintial)encryption method

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, result.username),
                        new Claim(ClaimTypes.Role, result.roleTitle)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
    }
}
