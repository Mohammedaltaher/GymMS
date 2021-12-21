using System.Collections.Generic;
using Application.Features.AdditionalFeatureFeatures.Commands;
using Application.Features.AdditionalFeatureFeatures.Queries;
using Domain.Entities;

namespace WebApi.Test.Settings;
public static class AdditionalFeatureData
{
    public static List<AdditionalFeature> MockAdditionalFeatureSamples()
    {
        var additionalFeature = new List<AdditionalFeature>()
            {
                new AdditionalFeature()
                {
                    Name = "Payment2",
                    Type = HallTypeEnum.Hall,
                },
                new AdditionalFeature()
                {
                    Name = "Payment",
                    Type = HallTypeEnum.Hall,
                }
            };

        return additionalFeature;
    }
    public static GetAdditionalFeatureByIdQuery MockGetAdditionalFeatureByIdQuery()
    {
        return new GetAdditionalFeatureByIdQuery()
        {
            Id = 1
        };
    }
    public static CreateAdditionalFeatureCommand MockCreateAdditionalFeatureCommand()
    {
        return new CreateAdditionalFeatureCommand()
        {
            Name = "Payment2",
            Type = HallTypeEnum.Hall,
        };
    }
    public static UpdateAdditionalFeatureCommand MockUpdateAdditionalFeatureCommand()
    {
        return new UpdateAdditionalFeatureCommand()
        {
            Id = 1,
            Name = "Payment25",
            Type = HallTypeEnum.Hall,
        };
    }
    public static DeleteAdditionalFeatureByIdCommand MockDeleteAdditionalFeatureByIdCommand()
    {
        return new DeleteAdditionalFeatureByIdCommand()
        {
            Id = 2
        };
    }

}
