using Interview.Services.Generic_Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Interview.Services
{
    public static class ServicesServiceCollectionExtension
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services)
        {
            //services.AddTransient<IActionDescriptorCollectionProvider, ActionDescriptorCollectionProvider>();
            services.AddTransient<EndpointEnumerationService>();

            return services;
        }
    }
}
