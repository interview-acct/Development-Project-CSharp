using AutoMapper;

namespace Interview.Mapper.DTO_DAL_Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Models.DTO_Objects.Category, Database.DAL_Objects.Category>()
                .ReverseMap();
        }
    }
}