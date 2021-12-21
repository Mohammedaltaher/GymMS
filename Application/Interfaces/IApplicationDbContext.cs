using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;
public interface IApplicationDbContext
{
    DbSet<User> DbUsers { get; set; }
    DbSet<Role> DbRoles { get; set; }
    DbSet<AdditionalFeature> AdditionalFeatures { get; set; }
    Task<int> SaveChangesAsync();
}

