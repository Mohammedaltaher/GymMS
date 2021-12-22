using Application.Common.Mapper;
using AutoMapper;
using Domain.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Test.Account;

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

    public static Mock<UserManager<User>> GetMockedUserManager<T>(List<User> ls , string? username = null)
    {
        var store = new Mock<IUserStore<User>>();
        var moq = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
        moq.Object.UserValidators.Add(new UserValidator<User>());
        moq.Object.PasswordValidators.Add(new PasswordValidator<User>());
        List<string> UserRoles = new();
        UserRoles.Add("user");

        moq.Setup(x => x.DeleteAsync(It.IsAny<User>())).ReturnsAsync(IdentityResult.Success);
        moq.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success).Callback<User, string>((x, y) => ls.Add(x));
        moq.Setup(x => x.UpdateAsync(It.IsAny<User>())).ReturnsAsync(IdentityResult.Success);
        moq.Setup(x => x.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);
        //moq.Setup(x => x.FindByEmailAsync(It.IsAny<string>())).Returns(IdentityResult.Success).Verifiable();
        moq.Setup(s => s.FindByEmailAsync(It.IsAny<string>())).Returns(Task.FromResult(AccountData.MockUsersSamples()[1])).Verifiable();
        moq.Setup(s => s.FindByNameAsync(username)).Returns(Task.FromResult(AccountData.MockUsersSamples().Find(c=>c.UserName == username)));
        moq.Setup(s => s.CheckPasswordAsync(It.IsAny<User>() , It.IsAny<string>())).Returns(Task.FromResult(true));
        moq.Setup(s => s.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult((IList<string>)UserRoles));
        return moq;

    }

    public static Mock<IConfiguration> GetMockedConfiguration<T>()
    {
        var moq = new Mock<IConfiguration>();
        moq.SetupGet(m => m[It.Is<string>(s => s == "Jwt:Issuer")]).Returns("Test.com");
        moq.SetupGet(m => m[It.Is<string>(s => s == "Jwt:Key")]).Returns("ThisismySecretKey");
        return moq;

    }
   
}
