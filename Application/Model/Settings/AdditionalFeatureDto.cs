using Application.Model.Common;
using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.settings
{
    public class AdditionalFeatureDto : BaseEntityDto
    {
        public string Name { get; set; }
        public HallTypeEnum Type { get; set; }
    }

   
}
