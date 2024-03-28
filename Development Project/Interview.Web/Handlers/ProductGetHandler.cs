using Interview.Models.App_Layer.Requests;
using Interview.Models.App_Layer.Responses;
using Interview.Services.Controller_Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Interview.Web.Handlers
{
    public class ProductGetHandler : IRequestHandler<ProductGetRequest, ProductGetResponse>
    {
        private ProductService _productService;

        public ProductGetHandler(IServiceProvider services)
        {
            _productService = new ProductService(services);
        }

        public async Task<ProductGetResponse> Handle(ProductGetRequest request, CancellationToken cancellationToken)
        {
            ProductGetResponse response = new ProductGetResponse();
            
            //call service code here
            response = await _productService.GetProduct(request);

            return response;
        }
    }
}
