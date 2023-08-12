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
            CreateMap<Service, ServiceWithImage>().ReverseMap();
            CreateMap<ServiceDTO, ServiceWithImage>().ReverseMap();
            CreateMap<Favorate, CreateFavorite>().ReverseMap();
            CreateMap<Favorate, FavoriteDTO>().ReverseMap();
            CreateMap<Appontment, CreateAppointment>().ReverseMap();
            CreateMap<Appontment, UserAppointment>().ReverseMap();
            CreateMap<Appontment, EmployeeAppointment>().ReverseMap();
            CreateMap<Appontment, AppointmentDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Employee, CreateEmployee>().ReverseMap();
            CreateMap<CostomerDet, CustomerDTO>().ReverseMap();
            CreateMap<Image, ImageDTO>().ReverseMap();
            CreateMap<Image, CreateImage>().ReverseMap();
            CreateMap<Gallery, GalleryDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
        }
    }
}

