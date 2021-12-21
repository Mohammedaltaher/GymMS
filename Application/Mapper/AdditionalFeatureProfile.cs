using Application.Features.AdditionalFeatureFeatures.Commands;
using Application.Model.settings;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mapper
{
    public class AdditionalFeatureProfile : Profile
    {
        public AdditionalFeatureProfile()
        {
            CreateMap<AdditionalFeature, CreateAdditionalFeatureCommand>();
            CreateMap<CreateAdditionalFeatureCommand, AdditionalFeature>();

            CreateMap<UpdateAdditionalFeatureCommand, AdditionalFeature>();

            CreateMap<AdditionalFeature, AdditionalFeatureDto>()
                .ForMember(from => from.CreatedByName, to => to.MapFrom(value => value.CreatedBy.UserName));
        }
    }
}
