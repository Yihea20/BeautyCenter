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
        private IGenericRepository<Appointment> _Appointment;
        private IGenericRepository<Center> _Center;
        private IGenericRepository<CustomerDet> _CustomerDet; 
        private IGenericRepository<Favorite> _Favorite;
        private IGenericRepository<Gallery> _Gallery;
        private IGenericRepository<Image> _Image;
        private IGenericRepository<Notification> _Notification;
        private IGenericRepository<Offers> _Offers;
        private IGenericRepository<User> _User;
        private IGenericRepository<Service> _Service;
        private IGenericRepository<ServiceEmployee> _ServiceEmployee;
        private IGenericRepository<Employee> _Employee;
        private IGenericRepository<TimeModel> _TimeModel { get; set; }
        public IGenericRepository<Appointment> Appointment => _Appointment ??= new GenericRepository<Appointment>(_context);
        public IGenericRepository<Center> Center => _Center ??= new GenericRepository<Center>(_context);
        public IGenericRepository<CustomerDet> CustomerDet => _CustomerDet ??= new GenericRepository<CustomerDet>(_context);
        public IGenericRepository<Favorite> Favorite => _Favorite ??= new GenericRepository<Favorite>(_context);
        public IGenericRepository<Gallery> Gallery => _Gallery??=new GenericRepository< Gallery>(_context);
        public IGenericRepository<Notification> Notification =>_Notification??=new GenericRepository<Notification>(_context);
        public IGenericRepository<Offers> Offers => _Offers??=new GenericRepository<Offers>(_context);
        public IGenericRepository<Service> Service => _Service ??= new GenericRepository<Service>(_context);
        public IGenericRepository<ServiceEmployee> ServiceEmployee =>_ServiceEmployee??= new GenericRepository<ServiceEmployee>(_context);
        public IGenericRepository<Employee> Employee => _Employee ??= new GenericRepository<Employee>(_context);
        public IGenericRepository<Image> Image => _Image??=new GenericRepository<Image>(_context);
        public IGenericRepository<User> User =>_User??=new GenericRepository<User>(_context);
        public IGenericRepository<TimeModel> TimeModel => _TimeModel ??= new GenericRepository<TimeModel>(_context);
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
