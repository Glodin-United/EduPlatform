using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Api.Data;

public sealed class PlatformDbContext(DbContextOptions<PlatformDbContext> options)
    : DbContext(options)
{
    public DbSet<Organization> Organizations => Set<Organization>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var organization = modelBuilder.Entity<Organization>();
        organization.HasKey(x => x.Id);
        organization.Property(x => x.Name).HasMaxLength(200).IsRequired();
        organization.Property(x => x.ExternalReference).HasMaxLength(100);
        organization.HasIndex(x => x.Name);
    }
}
