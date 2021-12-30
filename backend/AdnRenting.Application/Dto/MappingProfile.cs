using AdnRenting.Domain.Entities;
using AutoMapper;

namespace AdnRenting.Application.Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserInfoDto>().ReverseMap();
        }
    }
}
