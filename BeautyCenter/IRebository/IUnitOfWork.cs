using BeautyCenter.Models;
using System;

namespace BeautyCenter.IRebository
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<Appontment>Appontment {get;}
        public IGenericRepository<Center> Center { get;}
        public IGenericRepository<CostomerDet> CostomerDet { get; }
        public IGenericRepository<Favorate> Favorate { get; }
        public IGenericRepository<Gallery> Gallery { get; }
        public IGenericRepository<Image> Image { get; }
        public IGenericRepository<Notification> Notification { get; }
        public IGenericRepository<Offers> Offers { get; }

        public IGenericRepository<Service> Service { get; }
        public IGenericRepository<ServiceEmployee> ServiceEmployee { get; }
        public IGenericRepository<Employee> Employee { get; }

        public IGenericRepository<CostomerDet> Costomer { get; }

        Task Save();


    }
}
