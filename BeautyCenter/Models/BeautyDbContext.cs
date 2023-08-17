using BeautyCenter.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeautyCenter.Models
{
    public class BeautyDbContext:DbContext
    {
        public BeautyDbContext(DbContextOptions<BeautyDbContext> options) :base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();
            modelBuilder.Entity<User>().HasMany(vc => vc.ServicesOffers)
                         .WithMany(v => v.Users).UsingEntity<Appointment>(
                         vvc => vvc.HasOne(prop => prop.Service).WithMany().HasForeignKey(prop => prop.ServiceId).OnDelete(DeleteBehavior.Restrict),
                         vvc => vvc.HasOne(prop => prop.User).WithMany().HasForeignKey(prop => prop.UserID).OnDelete(DeleteBehavior.Restrict),
                         vvc => vvc.HasKey(prop => new { prop.UserID, prop.ServiceId })
                         );

            modelBuilder.Entity<Service>().HasMany(vc => vc.EmployeesHasService)
                           .WithMany(v => v.ServicesOffers).UsingEntity<Appointment>(
                           vvc => vvc.HasOne(prop => prop.Employee).WithMany().HasForeignKey(prop => prop.EmployeeId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasOne(prop => prop.Service).WithMany().HasForeignKey(prop => prop.ServiceId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasKey(prop => new { prop.EmployeeId, prop.ServiceId })
                           );
          
            modelBuilder.Entity<Service>().HasMany(vc => vc.EmployeesCanDo)
                           .WithMany(v => v.ServicesCanDo).UsingEntity<ServiceEmployee>(
                           vvc => vvc.HasOne(prop => prop.Employee).WithMany().HasForeignKey(prop => prop.EmployeeId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasOne(prop => prop.Service).WithMany().HasForeignKey(prop => prop.ServiceId).OnDelete(DeleteBehavior.Restrict),
                           vvc => vvc.HasKey(prop => new { prop.ServiceId, prop.EmployeeId })
                           );

         

            // modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceEmployee> ServiceEmployees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Package>Packages { get; set; }
        public DbSet<CustomerDet> CustomerDets { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<TimeModel> TimeModels { get; set; }
    }
   
}
