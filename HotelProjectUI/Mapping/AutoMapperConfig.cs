using AutoMapper;
using HotelProjectEntity.Concrete;
using HotelProjectUI.Dtos.AboutDto;
using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.LoginDto;
using HotelProjectUI.Dtos.RegisterDto;
using HotelProjectUI.Dtos.ServiceDto;
using HotelProjectUI.Dtos.StaffDto;

namespace HotelProjectUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultStaffDto,Staff>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
        }
    }
}
