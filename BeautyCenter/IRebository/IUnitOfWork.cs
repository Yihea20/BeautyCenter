using BeautyCenter.Models;
using System;

namespace BeautyCenter.IRebository
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<Appointment> Appointment { get; }
        public IGenericRepository<Review> Review { get; }
        public IGenericRepository<Center> Center { get; }
        public IGenericRepository<CustomerDet> CustomerDet { get; }
        public IGenericRepository<Favorite> Favorite { get; }
        public IGenericRepository<Gallery> Gallery { get; }
        public IGenericRepository<Image> Image { get; }
        public IGenericRepository<Notification> Notification { get; }
        public IGenericRepository<Offers> Offers { get; }

        public IGenericRepository<Service> Service { get; }
        public IGenericRepository<ServiceEmployee> ServiceEmployee { get; }
        public IGenericRepository<Employee> Employee { get; }
        public IGenericRepository<User> User { get; }
        public IGenericRepository<TimeModel> TimeModel { get; }
        Task Save();


    }
}
