using Application.Features.UserAccountFeatures.Commands;
using AutoMapper;
using Domain.Common;
using Domain.Entities;
using System;

namespace Application.Common.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, CreateUserAccountCommand>();
            CreateMap<CreateUserAccountCommand, User>()
                 .ForMember(dest => dest.SecurityStamp, o => o.MapFrom(src => Guid.NewGuid().ToString()))
                 ;
        }
    }
}
