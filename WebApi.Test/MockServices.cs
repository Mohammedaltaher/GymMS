using Application.Common.Mapper;
using AutoMapper;
using Domain.Common;
using Microsoft.AspNetCore.Identity;
using Moq;
using System.Collections.Generic;

namespace WebApi.Test;
public static class MockServices
{
    public static IMapper GetMockedMapper<T>()
    {
        var mappingConfig = new MapperConfiguration(profile =>
        {
            profile.AddProfile(new UserProfile());
            profile.AddProfile(new AdditionalFeatureProfile());
        });
        var moq = mappingConfig.CreateMapper();
        return moq;
    }

    public static Mock<UserManager<User>> GetMockedUserManager<T>(List<User> ls)
    {
        var store = new Mock<IUserStore<User>>();
        var moq = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
        moq.Object.UserValidators.Add(new UserValidator<User>());
        moq.Object.PasswordValidators.Add(new PasswordValidator<User>());

        moq.Setup(x => x.DeleteAsync(It.IsAny<User>())).ReturnsAsync(IdentityResult.Success);
        moq.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success).Callback<User, string>((x, y) => ls.Add(x));
        moq.Setup(x => x.UpdateAsync(It.IsAny<User>())).ReturnsAsync(IdentityResult.Success);
        moq.Setup(x => x.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);
        return moq;

    }
}
