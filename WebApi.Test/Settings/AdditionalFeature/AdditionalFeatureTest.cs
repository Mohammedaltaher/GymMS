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
using Application.Features.AdditionalFeatureFeatures.Commands;
using static Application.Features.AdditionalFeatureFeatures.Commands.CreateAdditionalFeatureCommand;
using static Application.Features.AdditionalFeatureFeatures.Queries.GetAdditionalFeatureByIdQuery;
using System.Linq;
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


    //#region CanAddTag
    //[Fact]
    //public void Can_add_tag()
    //{
    //    using (var transaction = Fixture.Connection.BeginTransaction())
    //    {
    //        using (var context = Fixture.CreateContext(transaction))
    //        {
    //            var controller = new ItemsController(context);

    //            var tag = controller.PostTag("ItemTwo", "Tag21").Value;

    //            Assert.Equal("Tag21", tag.Label);
    //            Assert.Equal(1, tag.Count);
    //        }

    //        using (var context = Fixture.CreateContext(transaction))
    //        {
    //            var item = context.Set<Item>().Include(e => e.Tags).Single(e => e.Name == "ItemTwo");

    //            Assert.Equal(1, item.Tags.Count);
    //            Assert.Equal("Tag21", item.Tags[0].Label);
    //            Assert.Equal(1, item.Tags[0].Count);
    //        }
    //    }
    //}
    //#endregion

    //#region CanUpTagCount
    //[Fact]
    //public void Can_add_tag_when_already_existing_tag()
    //{
    //    using (var transaction = Fixture.Connection.BeginTransaction())
    //    {
    //        using (var context = Fixture.CreateContext(transaction))
    //        {
    //            var controller = new ItemsController(context);

    //            var tag = controller.PostTag("ItemThree", "Tag32").Value;

    //            Assert.Equal("Tag32", tag.Label);
    //            Assert.Equal(3, tag.Count);
    //        }

    //        using (var context = Fixture.CreateContext(transaction))
    //        {
    //            var item = context.Set<Item>().Include(e => e.Tags).Single(e => e.Name == "ItemThree");

    //            Assert.Equal(2, item.Tags.Count);
    //            Assert.Equal("Tag31", item.Tags[0].Label);
    //            Assert.Equal(3, item.Tags[0].Count);
    //            Assert.Equal("Tag32", item.Tags[1].Label);
    //            Assert.Equal(3, item.Tags[1].Count);
    //        }
    //    }
    //}
    //#endregion

    //#region DeleteItem
    //[Fact]
    //public void Can_remove_item_and_all_associated_tags()
    //{
    //    using (var transaction = Fixture.Connection.BeginTransaction())
    //    {
    //        using (var context = Fixture.CreateContext(transaction))
    //        {
    //            var controller = new ItemsController(context);

    //            var item = controller.DeleteItem("ItemThree").Value;

    //            Assert.Equal("ItemThree", item.Name);
    //        }

    //        using (var context = Fixture.CreateContext(transaction))
    //        {
    //            Assert.False(context.Set<Item>().Any(e => e.Name == "ItemThree"));
    //            Assert.False(context.Set<Tag>().Any(e => e.Label.StartsWith("Tag3")));
    //        }
    //    }
    //}
    //#endregion
    //public static IMapper GetMockedMapper<T>()
    //{
    //    var moq = new Mock<IMapper>();
    //    return moq.Object;
    //}
    //#endregion

}




