using System.Collections.Generic;
using Application.Features.AdditionalFeatureFeatures.Commands;
using Application.Features.AdditionalFeatureFeatures.Queries;
using Application.Features.UserAccountFeatures.Commands;
using Domain.Common;
using Domain.Entities;

namespace WebApi.Test.Account;
public static class AccountData
{
    public static List<User> MockUsersSamples()
    {
        var user = new List<User>()
            {
                new User()
                {
                    Id="1",
                    UserName = "Mohammed Eltaher",
                    Email = "Mohammed@gmail.com"
                },
                new User()
                {
                    Id="2",
                    UserName = "Bakry Eltaher",
                    Email = "Bakry@gmail.com"
                },
            };

        return user;
    }
    public static CreateUserAccountCommand MockCreateUserAccountCommand()
    {
        return new CreateUserAccountCommand()
        {
            Name = "Mohammed Eltaher",
            Email= "Mohamed2@gmail.com",
            Role = AppRoleEnum.User,
            Password =  "Moh@123",
            RePassword = "Moh@123",
            Username = "mohammed2"
        };
    }
    public static RegisterUserAccountCommand MockRegisterUserCommand()
    {
        return new RegisterUserAccountCommand()
        {
            Name = "Bakry Eltaher",
            Email = "Bakry2@gmail.com",
            Password = "Moh@123",
            RePassword = "Moh@123",
            Username = "Bakry2"
        };
    }
    public static LoginCommand MockLoginCommand()
    {
        return new LoginCommand()
        {
            Username ="Mohammed2",
            Password ="Moh@123"
        };
    }

}
