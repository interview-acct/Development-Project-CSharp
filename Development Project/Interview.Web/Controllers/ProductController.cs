using Interview.Models.App_Layer.Requests;
using Interview.Models.App_Layer.Responses;
using Interview.Services.Generic_Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Interview.Web.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        private readonly EndpointEnumerationService _endpointService;

        public ProductController(IMediator mediator, IServiceProvider services)
        {
            _mediator = mediator;
            _endpointService = services.GetRequiredService<EndpointEnumerationService>();
        }

        // NOTE: Sample Action
        [HttpGet]
        public Task<IActionResult> GetAllProducts()
        {
            return Task.FromResult((IActionResult)Ok(new object[] { }));
        }

        [HttpPost]
        public async Task<IActionResult> GetProduct(ProductGetRequest request)
        {
            var result = await _mediator.Send(request);

            Response<ProductGetResponse> response = new Response<ProductGetResponse>();
            response.Data = result;
            response.RelatedEndpoints = (List<object>)_endpointService.GetAllEndpointsForController("ProductController");

            return Ok(response);
        }
    }
}
