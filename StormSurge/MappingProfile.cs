using AutoMapper;
using Entities;
using Shared.DataTransferObjects;


namespace StormSurge
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
         
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<FloodZoneDTO, FloodZone>();
            CreateMap<FloodZone, FloodZoneDTO>();
         

        }

    }
}
