using Application.Interfaces;
using Application.Model.Common;
using Application.Model.settings;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.AdditionalFeatureFeatures.Commands
{
    public class DeleteAdditionalFeatureByIdCommand : IRequest<BaseModel>
    {
        public int Id { get; set; }
        public class DeleteAdditionalFeatureByIdCommandHandler : IRequestHandler<DeleteAdditionalFeatureByIdCommand, BaseModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public DeleteAdditionalFeatureByIdCommandHandler(IApplicationDbContext context , IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<BaseModel> Handle(DeleteAdditionalFeatureByIdCommand command, CancellationToken cancellationToken)
            {
                var AdditionalFeature = await _context.AdditionalFeatures.Where(a => a.Id == command.Id).FirstOrDefaultAsync(cancellationToken: cancellationToken);
                if (AdditionalFeature == null)
                {
                    return new BaseModel
                    {
                        Data = 0,
                        StatusCode = 404,
                        Messege = "No data found"
                    };
                };
                AdditionalFeature.IsDeleted = true;
            //    _context.AdditionalFeatures.Update(AdditionalFeature);
                await _context.SaveChangesAsync();
                return new BaseModel
                {
                    Data = _mapper.Map<AdditionalFeatureDto>(AdditionalFeature),
                    StatusCode = 200,
                    Messege = "Data has been Deleted"
                };
            }
        }
    }
}
