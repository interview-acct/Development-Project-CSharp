using AutoMapper;

namespace Interview.Mapper.DTO_DAL_Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Models.DTO_Objects.Product, Database.DAL_Objects.Product>()
                .ReverseMap();
        }
    }
}
