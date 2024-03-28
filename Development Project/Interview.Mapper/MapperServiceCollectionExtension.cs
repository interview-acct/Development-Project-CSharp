using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using Interview.Mapper.DTO_DAL_Profiles;

namespace Interview.Mapper
{
    public static class MapperServiceCollectionExtension
    {
        public static IServiceCollection AddMapperServices(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductProfile());
                cfg.AddProfile(new AttributeProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new TransactionProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
