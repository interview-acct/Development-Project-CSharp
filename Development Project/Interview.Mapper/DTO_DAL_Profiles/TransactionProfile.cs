using AutoMapper;

namespace Interview.Mapper.DTO_DAL_Profiles
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Models.DTO_Objects.Transaction, Database.DAL_Objects.Transaction>()
                .ReverseMap();
        }
    }
}