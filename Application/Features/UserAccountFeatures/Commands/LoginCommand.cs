using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using Application.Common;
using Application.Model.Common;
using Microsoft.AspNetCore.Http;

namespace Application.Features.UserAccountFeatures.Commands
{
    public class LoginCommand : IRequest<BaseModel>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public class LoginCommandHandler : IRequestHandler<LoginCommand, BaseModel>
        {
            private readonly UserManager<User> _userManager;
            private readonly IConfiguration _configuration;
            public LoginCommandHandler( UserManager<User> userManager, IConfiguration configuration)
            {
                _userManager = userManager;
                _configuration = configuration;
            }
            public async Task<BaseModel> Handle(LoginCommand command, CancellationToken cancellationToken)
            {

                var user = await _userManager.FindByNameAsync(command.Username);
                if (user == null)
                {
                    return new BaseModel
                    {
                        StatusCode = StatusCodes.Status405MethodNotAllowed,
                        Messege = "User not exists"
                    };
                }
                if (!await _userManager.CheckPasswordAsync(user, command.Password))
                {
                    return new BaseModel
                    {
                        StatusCode = StatusCodes.Status405MethodNotAllowed,
                        Messege = "User password wrong"
                    };
                }

                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                    {
                              new Claim(ClaimTypes.Name, user.UserName),
                              new Claim(ClaimTypes.NameIdentifier, user.Id),
                              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                  _configuration["Jwt:Issuer"],
                   claims: authClaims,
                  expires: DateTime.Now.AddMinutes(120),
                  signingCredentials: credentials);

                return new BaseModel
                {
                    Data = new JWTTokenModel
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                        Expiration = token.ValidTo
                    },
                    StatusCode = StatusCodes.Status200OK,
                    Messege = "User Login successfully"
                };
            }
        }
    }
}
