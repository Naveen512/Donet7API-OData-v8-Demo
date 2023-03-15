using Dot7.OData.Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot7.OData.Demo.Data;

public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employee { get; set; }
    public DbSet<EmployeeAddresses> EmployeeAddresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeAddresses>()
        .HasOne(_ => _.Employee)
        .WithMany(_ => _.EmployeeAddresses)
        .HasForeignKey(_ => _.EmployeeId);
    }
}