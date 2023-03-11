using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WEB_MVC.Models;

namespace WEB_MVC.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>().HasKey(br =>
            br.ConcernId);
        modelBuilder.Entity<Phone>().HasKey(ph =>
            ph.BrandId);
        
        modelBuilder.Entity<Brand>().HasOne(br => br._Concern).WithMany(br => br.Brands)
            .HasForeignKey(br => br.ConcernId);
        
        modelBuilder.Entity<Phone>().HasOne(ph => ph._Brand).WithMany(br => br.Phones)
            .HasForeignKey(ph => ph.BrandId);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Phone> Phones { get; set; }
    public DbSet<Concerns> Concerns { get; set; }
    public DbSet<Brand> Brands { get; set; }
    
}