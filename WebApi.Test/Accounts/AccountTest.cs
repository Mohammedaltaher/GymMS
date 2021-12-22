using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Moq;
using Xunit;
using Application.Model.Common;
using Domain.Common;
using static Application.Features.UserAccountFeatures.Commands.CreateUserAccountCommand;
using static Application.Features.UserAccountFeatures.Commands.RegisterUserAccountCommand;

namespace WebApi.Test.Account;
public class AccountTest : IClassFixture<SharedDatabaseFixture>
{
    public SharedDatabaseFixture Fixture { get; }
    private readonly Mock<IApplicationDbContext> MockContext;


    public AccountTest(SharedDatabaseFixture fixture)
    {
        Fixture = fixture;
        MockContext = new Mock<IApplicationDbContext>();
        MockContext.Setup(db => db.DbUsers).Returns(Fixture.CreateContext().DbUsers);
    }


    [Fact]
    public async Task Can_Add_CreateUserAccountAsync()
    {
        var handler = new CreateUserAccountCommandHandler(MockContext.Object, MockServices.GetMockedUserManager<User>(AccountData.MockUsersSamples()).Object);
        BaseModel result = await handler.Handle(AccountData.MockCreateUserAccountCommand(), CancellationToken.None);
        var userId = (string)result.Data;
        Assert.NotEmpty(userId);
    }
    [Fact]
    public async Task Can_Add_RegisterUserAccountAsync()
    {
        var handler = new RegisterUserAccountCommandHandler(MockContext.Object, MockServices.GetMockedUserManager<User>(AccountData.MockUsersSamples()).Object);
        BaseModel result = await handler.Handle(AccountData.MockRegisterUserCommand(), CancellationToken.None);
        var userId = (string)result.Data;
        Assert.NotEmpty(userId);
    }


}




