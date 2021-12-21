using Application.Interfaces;
using Application.Model.Common;
using Application.Model.settings;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.AdditionalFeatureFeatures.Queries
{
    public class GetAdditionalFeatureByIdQuery : IRequest<BaseModel>
    {
        public int Id { get; set; }
        public class GetAdditionalFeatureByIdQueryHandler : IRequestHandler<GetAdditionalFeatureByIdQuery, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetAdditionalFeatureByIdQueryHandler(IApplicationDbContext context , IMapper mapper)
            {
                _context = context;
                _mapper = mapper;

            }
            public Task<BaseModel> Handle(GetAdditionalFeatureByIdQuery query, CancellationToken cancellationToken)
            {
                var AdditionalFeature = _context.AdditionalFeatures.Where(a => a.Id == query.Id).AsNoTracking().FirstOrDefault();
                if (AdditionalFeature == null)
                {
                    return Task.FromResult(new BaseModel
                    {
                        Data = null ,
                        StatusCode = 404,
                        Messege = "No data found"
                    });
                }
                return Task.FromResult(new BaseModel
                {
                    Data = _mapper.Map<AdditionalFeatureDto>(AdditionalFeature),
                    StatusCode = 200,
                    Messege = "Data found"
                });
            }
        }
    }
}
