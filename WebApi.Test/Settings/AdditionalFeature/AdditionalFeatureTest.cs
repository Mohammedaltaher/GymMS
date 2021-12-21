using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Moq;
using Xunit;
using Application.Model.Common;
using Application.Features.AdditionalFeatureFeatures.Queries;
using static Application.Features.AdditionalFeatureFeatures.Queries.GetAllAdditionalFeaturesQuery;
using Application.Model.settings;
using System.Collections.Generic;
using static Application.Features.AdditionalFeatureFeatures.Commands.CreateAdditionalFeatureCommand;
using static Application.Features.AdditionalFeatureFeatures.Queries.GetAdditionalFeatureByIdQuery;
using static Application.Features.AdditionalFeatureFeatures.Commands.UpdateAdditionalFeatureCommand;
using static Application.Features.AdditionalFeatureFeatures.Commands.DeleteAdditionalFeatureByIdCommand;

namespace WebApi.Test.Settings;
public class AdditionalFeatureTest : IClassFixture<SharedDatabaseFixture>
{
    public SharedDatabaseFixture Fixture { get; }
    private readonly Mock<IApplicationDbContext> MockContext;


    public AdditionalFeatureTest(SharedDatabaseFixture fixture)
    {
        Fixture = fixture;
        MockContext = new Mock<IApplicationDbContext>();
        MockContext.Setup(db => db.AdditionalFeatures).Returns(Fixture.CreateContext().AdditionalFeatures);
    }


    [Fact]
    public async Task Can_Get_All_AdditionalFeaturesAsync()
    {
        var handler = new GetAllAdditionalFeaturesQueryHandler(MockContext.Object, MockServices.GetMockedMapper<IMapper>());
        BaseModel result = await handler.Handle(new GetAllAdditionalFeaturesQuery(), CancellationToken.None);
        var additionalFeature = (List<AdditionalFeatureDto>)result.Data;
        Assert.NotNull(additionalFeature);
        Assert.Equal(AdditionalFeatureData.MockAdditionalFeatureSamples()[0].Name, additionalFeature[0].Name);
        Assert.Equal(2, additionalFeature.Count);
       
    }


    [Fact]
    public async Task Can_Get_AdditionalFeature_By_IdAsync()
    {
        var handler = new GetAdditionalFeatureByIdQueryHandler(MockContext.Object, MockServices.GetMockedMapper<IMapper>());
        BaseModel result = await handler.Handle(AdditionalFeatureData.MockGetAdditionalFeatureByIdQuery(), CancellationToken.None);
        var additionalFeature = (AdditionalFeatureDto)result.Data;

        Assert.Equal("Payment2", additionalFeature.Name);
    }


    [Fact]
    public async Task Can_Add_AdditionalFeatureAsync()
    {
        var handler = new CreateAdditionalFeatureCommandHandler(MockContext.Object, MockServices.GetMockedMapper<IMapper>());
        BaseModel result = await handler.Handle(AdditionalFeatureData.MockCreateAdditionalFeatureCommand(), CancellationToken.None);
        var additionalFeature = (AdditionalFeatureDto)result.Data;

        Assert.Equal("Payment2", additionalFeature.Name);
    }
   
    
    [Fact]
    public async Task Can_Update_AdditionalFeatureAsync()
    {
        var handler = new UpdateAdditionalFeatureCommandHandler(MockContext.Object, MockServices.GetMockedMapper<IMapper>());
        BaseModel result = await handler.Handle(AdditionalFeatureData.MockUpdateAdditionalFeatureCommand(), CancellationToken.None);
        var additionalFeature = (AdditionalFeatureDto)result.Data;

        Assert.Equal("Payment25", additionalFeature.Name);
    }
  
    
    [Fact]
    public async Task Can_Delete_AdditionalFeatureAsync()
    {
        var handler = new DeleteAdditionalFeatureByIdCommandHandler(MockContext.Object, MockServices.GetMockedMapper<IMapper>());
        BaseModel result = await handler.Handle(AdditionalFeatureData.MockDeleteAdditionalFeatureByIdCommand(), CancellationToken.None);
        var additionalFeature = (AdditionalFeatureDto)result.Data;

        Assert.Equal("Payment", additionalFeature.Name);
    }
}




