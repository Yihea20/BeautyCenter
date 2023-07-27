using BeautyCenter.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeautyCenter.Models
{
    public class BeautyDbContext:IdentityDbContext
    {
        public BeautyDbContext(DbContextOptions<BeautyDbContext> options) :base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(vc => vc.ServicesOffers)
                         .WithMany(v => v.Users).UsingEntity<Appontment>(
                         vvc => vvc.HasOne(prop => prop.Service).WithMany().HasForeignKey(prop => prop.ServiceId).OnDelete(DeleteBehavior.Restrict),
                         vvc => vvc.HasOne(prop => prop.User).WithMany().HasForeignKey(prop => prop.UserID).OnDelete(DeleteBehavior.Restrict),
                         vvc => vvc.HasKey(prop => new { prop.UserID, prop.ServiceId })
                         );

            modelBuilder.Entity<Service>().HasMany(vc => vc.Employees)
                           .WithMany(v => v.ServicesOffers).UsingEntity<Appontment>(
                           vvc => vvc.HasOne(prop => prop.Employee).WithMany().HasForeignKey(prop => prop.EmployeeId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasOne(prop => prop.Service).WithMany().HasForeignKey(prop => prop.ServiceId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasKey(prop => new { prop.EmployeeId, prop.ServiceId })
                           );
          
            modelBuilder.Entity<Service>().HasMany(vc => vc.Employees)
                           .WithMany(v => v.ServicesCanDo).UsingEntity<ServiceEmployee>(
                           vvc => vvc.HasOne(prop => prop.Employee).WithMany().HasForeignKey(prop => prop.EmployeeId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasOne(prop => prop.Service).WithMany().HasForeignKey(prop => prop.ServiceId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasKey(prop => new { prop.ServiceId, prop.EmployeeId })
                           );

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Favorate> Favorates { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceEmployee> ServiceEmployees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appontment> Appontments { get; set; }
        public DbSet<Package>Packages { get; set; }
        public DbSet<CostomerDet> CostomerDets { get; set; }
    }
   
}
