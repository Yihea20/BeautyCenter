using AutoMapper;
using BeautyCenter.DTOs;
using static BeautyCenter.DTOs.CreateCenter;

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
        }
    }
}
