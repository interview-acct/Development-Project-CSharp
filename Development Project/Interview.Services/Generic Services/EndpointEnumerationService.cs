using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Services.Generic_Services
{
    public class EndpointEnumerationService
    {
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;

        public EndpointEnumerationService(IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
        }

        public IEnumerable<object> GetAllEndpointsForController(string controllerName)
        {
            return _actionDescriptorCollectionProvider.ActionDescriptors.Items
                .Where(descriptor => descriptor.RouteValues.ContainsKey("controller") &&
                                     descriptor.RouteValues["controller"].Equals(controllerName, System.StringComparison.OrdinalIgnoreCase))
                .Select(descriptor =>
                {
                // Attempt to find HttpMethodMetadata in the endpoint metadata
                var httpMethodMetadata = descriptor.EndpointMetadata.OfType<HttpMethodMetadata>().FirstOrDefault();
                    var methods = httpMethodMetadata?.HttpMethods;

                    return new
                    {
                        Action = descriptor.RouteValues["action"],
                        Method = descriptor.AttributeRouteInfo?.Template,
                        HttpMethods = methods != null ? string.Join(", ", methods) : "GET"
                    };
                });
        }
    }
}
