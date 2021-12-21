using Application.Common.Mapper;
using AutoMapper;
using Moq;

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
}
