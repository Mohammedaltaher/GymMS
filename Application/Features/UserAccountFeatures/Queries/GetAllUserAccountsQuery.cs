//using Application.Interfaces;
//using MediatR;
//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using Domain.Common;
//using System.Collections.Generic;
//using Microsoft.AspNetCore.Identity;

//namespace Application.Features.UserAccountFeatures.Queries
//{
//    public class GetAllUserAccountsQuery : IRequest<ApplicationUser>
//    {
//        public class GetAllUserAccountsQueryHandler : IRequestHandler<GetAllUserAccountsQuery, ApplicationUser>
//        {
//            private readonly IApplicationDbContext _context;
//            private readonly UserManager<ApplicationUser> _userManager;
//            public GetAllUserAccountsQueryHandler(IApplicationDbContext context , UserManager<ApplicationUser> userManager)
//            {
//                _context = context;
//                _userManager = userManager;
//            }
//            public async Task<ApplicationUser> Handle(GetAllUserAccountsQuery query, CancellationToken cancellationToken)
//            {
//                var user = await _userManager.FindByNameAsync("dfhs");
//                var UserAccountList = await _userManager.GetUserIdAsync(user);
//                if (UserAccountList == null)
//                {
//                    return null;
//                }
//                return user;
//            }
//        }
//    }
//}
