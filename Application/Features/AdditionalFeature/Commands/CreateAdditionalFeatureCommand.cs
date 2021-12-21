using Application.Interfaces;
using Application.Model.Common;
using Application.Model.settings;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.AdditionalFeatureFeatures.Commands
{
    public class CreateAdditionalFeatureCommand : IRequest<BaseModel>
    {
        public string Name { get; set; }
        public HallTypeEnum Type { get; set; }
        public class CreateAdditionalFeatureCommandHandler : IRequestHandler<CreateAdditionalFeatureCommand, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public CreateAdditionalFeatureCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<BaseModel> Handle(CreateAdditionalFeatureCommand command, CancellationToken cancellationToken)
            {
                var AdditionalFeature = _mapper.Map<AdditionalFeature>(command);
                _context.AdditionalFeatures.Add(AdditionalFeature);

                await _context.SaveChangesAsync();
                return new BaseModel
                {
                    Data = _mapper.Map<AdditionalFeatureDto>(AdditionalFeature),
                    StatusCode = 200,
                    Messege = "Data has been added"
                };
            }
        }
    }
}
