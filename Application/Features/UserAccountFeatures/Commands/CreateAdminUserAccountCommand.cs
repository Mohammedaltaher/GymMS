using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using AutoMapper;
using Application.Model.Common;
using Microsoft.AspNetCore.Http;
using Application.Helper.Common;

namespace Application.Features.UserAccountFeatures.Commands
{
    public class CreateAdminUserAccountCommand : IRequest<BaseModel>
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public class CreateAdminUserAccountCommandHandler : IRequestHandler<CreateAdminUserAccountCommand, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly UserManager<User> _userManager;
            public CreateAdminUserAccountCommandHandler(IApplicationDbContext context, UserManager<User> userManager)
            {
                _context = context;
                _userManager = userManager;
            }

            

            public async Task<BaseModel> Handle(CreateAdminUserAccountCommand command, CancellationToken cancellationToken)
            {

                var userExists = await _userManager.FindByNameAsync(command.Username);
                if (userExists != null)
                {
                    return new BaseModel
                    {
                        StatusCode = StatusCodes.Status405MethodNotAllowed,
                        Messege = "User already exists"
                    };
                }
                var UserAccount = new User
                {
                    Email = command.Email,
                    UserName = command.Username,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var addUser = await _userManager.CreateAsync(UserAccount, command.Password);
                if (!addUser.Succeeded)
                {
                    return new BaseModel
                    {
                        StatusCode = StatusCodes.Status405MethodNotAllowed,
                        Messege = "User not Created"
                    };
                }

                var addUserRole = await _userManager.AddToRoleAsync(UserAccount, AppRoleEnum.Admin.GetDescription());
                if (!addUserRole.Succeeded)
                {
                    return new BaseModel
                    {
                        StatusCode = StatusCodes.Status405MethodNotAllowed,
                        Messege = "User Created successfully but role not added "
                    };
                }
                await _context.SaveChangesAsync();
                return new BaseModel
                {
                    Data = UserAccount.Id,
                    StatusCode = StatusCodes.Status200OK,
                    Messege = "User Created successfully with role "
                };
            }
        }
    }
}
