using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Application.Model.Common;
using Microsoft.AspNetCore.Http;
using Application.Helper.Common;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.UserAccountFeatures.Commands
{
    public class CreateUserAccountCommand : IRequest<BaseModel>
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name too long (50 character limit).")]
        public string Name { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "User Name too long (16 character limit).")]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RePassword { get; set; }
        public AppRoleEnum Role { get; set; }
        public class CreateUserAccountCommandHandler : IRequestHandler<CreateUserAccountCommand, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly UserManager<User> _userManager;
            public CreateUserAccountCommandHandler(IApplicationDbContext context, UserManager<User> userManager)
            {
                _context = context;
                _userManager = userManager;
            }
            public async Task<BaseModel> Handle(CreateUserAccountCommand command, CancellationToken cancellationToken)
            {

                var userExists = await _userManager.FindByNameAsync(command.Username);
                if (userExists != null)
                {
                    return new BaseModel
                    {
                        StatusCode = StatusCodes.Status405MethodNotAllowed,
                        Messege = "User name  already exists"
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
                        Messege = "User not registered "
                    };
                }


                var addUserRole = await _userManager.AddToRoleAsync(UserAccount, command.Role.GetDescription());
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
