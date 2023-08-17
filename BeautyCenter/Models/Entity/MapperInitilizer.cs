using AutoMapper;
using BeautyCenter.DTOs;
using static BeautyCenter.DTOs.CreateCenter;
using static BeautyCenter.DTOs.CreateOffer;
using static BeautyCenter.DTOs.CreateService;
using static BeautyCenter.DTOs.CreateFavorite;
using static BeautyCenter.DTOs.CreateAppointment;
using static BeautyCenter.DTOs.CreateEmployee;
using static BeautyCenter.DTOs.CreateCustomer;
using static BeautyCenter.DTOs.CreateGallery;
namespace BeautyCenter.Models.Entity
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<User, UserLoginDTO>().ReverseMap();
            CreateMap<User, UserRegistDTO>().ReverseMap();
            CreateMap<Center, CreateCenter>().ReverseMap();
            CreateMap<Center, CenterDTO>().ReverseMap();
            CreateMap<Offers, CreateOffer>().ReverseMap();
            CreateMap<Offers, OfferDTO>().ReverseMap();
            CreateMap<Service, ServiceDTO>().ReverseMap();
            CreateMap<Service, CreateService>().ReverseMap();
            CreateMap<Service, UpdateService>().ReverseMap();
            CreateMap<Favorite, CreateFavorite>().ReverseMap();
            CreateMap<Favorite, FavoriteDTO>().ReverseMap();
            CreateMap<Appointment, CreateAppointment>().ReverseMap();
            CreateMap<Appointment, UserAppointment>().ReverseMap();
            CreateMap<Appointment, EmployeeAppointment>().ReverseMap();
            CreateMap<Appointment, AppointmentDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Employee, CreateEmployee>().ReverseMap();
            CreateMap<CustomerDet, CustomerDTO>().ReverseMap();
            CreateMap<Image, ImageDTO>().ReverseMap();
            CreateMap<Image, CreateImage>().ReverseMap();
            CreateMap<Gallery, GalleryDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
            CreateMap<TimeModel, TimeDTO>().ReverseMap();
            CreateMap<TimeModel, CreateTiem>().ReverseMap();
        }
    }
}

