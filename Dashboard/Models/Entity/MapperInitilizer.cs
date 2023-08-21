using AutoMapper;
using Dashboard.DTOs;

using static Dashboard.DTOs.CreateAppointment;

using Dashboard.DTOs;
using Dashboard.Pages;

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
           
        }
    }
}

