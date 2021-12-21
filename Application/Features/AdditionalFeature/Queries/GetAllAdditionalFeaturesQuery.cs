using Application.Interfaces;
using Application.Model.Common;
using Application.Model.settings;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.AdditionalFeatureFeatures.Queries
{
    public class GetAllAdditionalFeaturesQuery : IRequest<BaseModel>
    {

        public class GetAllAdditionalFeaturesQueryHandler : IRequestHandler<GetAllAdditionalFeaturesQuery, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetAllAdditionalFeaturesQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<BaseModel> Handle(GetAllAdditionalFeaturesQuery query, CancellationToken cancellationToken)
            {
                var AdditionalFeatureList = await _context.AdditionalFeatures
                    .AsNoTracking()
                    .Include(x=>x.CreatedBy)
                    .ToListAsync(cancellationToken: cancellationToken);

                if (AdditionalFeatureList == null)
                {
                    return new BaseModel
                    {
                        Data = null,
                        StatusCode = 200,
                        Messege = "No data found"
                    };
                }
                var d = _mapper.Map<List<AdditionalFeatureDto>>(AdditionalFeatureList);
                return new BaseModel
                {
                    Data = _mapper.Map<List<AdditionalFeatureDto>>(AdditionalFeatureList),
                    StatusCode = 200,
                    Messege = "Data found"
                }; 
            }
        }
    }
}
