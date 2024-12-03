using System;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.Common;
using HR.LeaveManagement.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.DatabaseContext;

public class HrDatabaseContext : DbContext
{
    public HrDatabaseContext(DbContextOptions<HrDatabaseContext> options) : base(options)
    {

    }

    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrDatabaseContext).Assembly);
        //OTHER WAYS
        // modelBuilder.ApplyConfiguration(new LeaveTypeConfiguration());

        base.OnModelCreating(modelBuilder);
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        //track apakah entity di tambah atau hanya di update
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
        .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            //jika di modified
            entry.Entity.DateModified = DateTime.Now;

            //jika di tambahkan
            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
