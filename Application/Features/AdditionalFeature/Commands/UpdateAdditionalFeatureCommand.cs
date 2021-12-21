using Application.Interfaces;
using Application.Model.Common;
using Application.Model.settings;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.AdditionalFeatureFeatures.Commands
{
    public class UpdateAdditionalFeatureCommand : IRequest<BaseModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HallTypeEnum Type { get; set; }
        public class UpdateAdditionalFeatureCommandHandler : IRequestHandler<UpdateAdditionalFeatureCommand, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public UpdateAdditionalFeatureCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<BaseModel> Handle(UpdateAdditionalFeatureCommand command, CancellationToken cancellationToken)
            {
                AdditionalFeature AdditionalFeature = _context.AdditionalFeatures.Where(a => a.Id == command.Id).FirstOrDefault();

                if (AdditionalFeature == null)
                {
                    return new BaseModel
                    {
                        Data = 0,
                        StatusCode = 404,
                        Messege = "no data found"
                    };
                }
                else
                {
                    AdditionalFeature = _mapper.Map<AdditionalFeature>(command);
                //    _context.AdditionalFeatures.Update(AdditionalFeature);
                    await _context.SaveChangesAsync();
                    return new BaseModel
                    {
                        Data = _mapper.Map<AdditionalFeatureDto>(AdditionalFeature),
                        StatusCode = 200,
                        Messege = "Data has been updated"
                    };
                }
            }
        }
    }
}
