using AutoMapper;
using CMS.DAL.Entities;

namespace CMS.DAL.MapperProfiles
{
    public class MusicMapperProfile : Profile
    {
        public MusicMapperProfile()
        {
            CreateMap<MusicEntity, MusicEntity>();
        }
    }
}