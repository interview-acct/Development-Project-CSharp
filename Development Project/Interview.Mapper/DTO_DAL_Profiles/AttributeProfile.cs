using AutoMapper;

namespace Interview.Mapper.DTO_DAL_Profiles
{
    public class AttributeProfile : Profile
    {
        public AttributeProfile()
        {
            CreateMap<Models.DTO_Objects.Attribute, Database.DAL_Objects.Attribute>()
                .ReverseMap();
        }
    }
}
