using BeautyCenter.IRebository;
using BeautyCenter.Models;

namespace BeautyCenter.Rebository
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly BeautyDbContext _context;

        public UnitOfWork(BeautyDbContext context)
        {
            _context = context;
        }

        private IGenericRepository<Appontment> _Appontment;
        private IGenericRepository<Center> _Center;
        private IGenericRepository<CostomerDet> _CostomerDet; 
        private IGenericRepository<Favorate> _Favorate;
        private IGenericRepository<Gallery> _Gallery;
        private IGenericRepository<Image> _Image;
        private IGenericRepository<Notification> _Notification;
        private IGenericRepository<Offers> _Offers;

        private IGenericRepository<Service> _Service;
        private IGenericRepository<ServiceEmployee> _ServiceEmployee;
        private IGenericRepository<Employee> _Employee;

        public IGenericRepository<Appontment> Appontment =>_Appontment??=new GenericRepository<Appontment
            >(_context);

        public IGenericRepository<Center> Center =>_Center??=new GenericRepository<Center>(_context);

        public IGenericRepository<CostomerDet> CostomerDet => _CostomerDet??=new GenericRepository<CostomerDet>(_context);

        public IGenericRepository<Favorate> Favorate =>_Favorate??=new GenericRepository<Favorate>(_context);

        public IGenericRepository<Gallery> Gallery => _Gallery??=new GenericRepository< Gallery>(_context);

        public IGenericRepository<Notification> Notification =>_Notification??=new GenericRepository<Notification>(_context);

        public IGenericRepository<Offers> Offers => _Offers??=new GenericRepository<Offers>(_context);

        

        public IGenericRepository<Service> Service =>_Service??= new GenericRepository<Service>(_context);

        public IGenericRepository<ServiceEmployee> ServiceEmployee =>_ServiceEmployee??= new GenericRepository<ServiceEmployee>(_context);

        public IGenericRepository<Employee> Employee => _Employee ??= new GenericRepository<Employee>(_context);

        public IGenericRepository<Image> Image => _Image??=new GenericRepository<Image>(_context);

        public IGenericRepository<CostomerDet> Costomer => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
