using AutoMapper;
using DtoLayer.Dtos.RoomDto;
using HotelProjectEntity.Concrete;
using System.Runtime;

namespace HotelProject.Weba.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
