using AutoMapper;
using Dashboard.DTOs;

using static Dashboard.DTOs.CreateAppointment;

using Dashboard.DTOs;
using Dashboard.Pages;
using Dashboard.Data;

namespace Dashboard.Models.Entity
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            
            CreateMap<Appointment, CreateAppointment>().ReverseMap();
            CreateMap<Appointment, UserAppointment>().ReverseMap();
            CreateMap<Appointment, EmployeeAppointment>().ReverseMap();
            CreateMap<Appointment, AppointmentDTO>().ReverseMap();
            CreateMap<Service, ServiceDTO>().ReverseMap();
            CreateMap<Service, CreateService>().ReverseMap();
            CreateMap<Service, UpdateService>().ReverseMap();
            CreateMap<Center, CreateCenter>().ReverseMap();
            CreateMap<Center, CenterDTO>().ReverseMap();

        }
    }
}

