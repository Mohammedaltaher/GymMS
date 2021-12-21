using Application.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Persistence.Context;
public class ApplicationDbContext : IdentityDbContext<IdentityUser>, IApplicationDbContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly string _userId = "";
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
        : base(options)
    {
        _httpContextAccessor = httpContextAccessor;
        _userId = _httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        MapModelBuilder(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
    private void MapModelBuilder(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Product>().HasQueryFilter(b => EF.Property<string>(b, "TenantId") == _tenantId);
        modelBuilder.Entity<User>().HasOne(a => a.UserProfile).WithOne(a => a.User).HasForeignKey<UserProfile>(c => c.UserId);
        modelBuilder.Entity<AdditionalFeature>().HasQueryFilter(p => !p.IsDeleted);
        //To Do add all the tables...
    }
    public async Task<int> SaveChangesAsync()
    {
        AddUserId();
        UpdateUpdateDate();
        return await base.SaveChangesAsync();
    }
    private void AddUserId()
    {
        var CreatedById = "CreatedById";
        ChangeTracker.DetectChanges();
        var modified = ChangeTracker.Entries().Where(x => x.State == EntityState.Added);
        foreach (EntityEntry entity in modified)
        {
            foreach (PropertyEntry prop in entity.Properties)
            {
                if (prop.Metadata.Name == CreatedById)
                {
                    if (entity.CurrentValues[CreatedById] == null && _userId != null)
                        entity.CurrentValues[CreatedById] = _userId;
                }
            }
        }
    }
    private void UpdateUpdateDate()
    {
        var UpdateDate = "UpdateDate";
        ChangeTracker.DetectChanges();
        var modified = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
        foreach (EntityEntry entity in modified)
        {
            foreach (PropertyEntry prop in entity.Properties)
            {
                if (prop.Metadata.Name == UpdateDate)
                {
                    entity.CurrentValues[UpdateDate] = DateTime.Now;
                }
            }
        }
    }

    #region DbSet Properties
    public DbSet<User> DbUsers { get; set; }
    public DbSet<Role> DbRoles { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<AdditionalFeature> AdditionalFeatures { get; set; }
   
    #endregion
}

