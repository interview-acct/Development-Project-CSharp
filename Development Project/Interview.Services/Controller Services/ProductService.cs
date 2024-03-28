using Interview.Database.Contexts;
using Interview.Models.App_Layer.Requests;
using Interview.Models.App_Layer.Responses;
using Interview.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Controller_Services
{
    public class ProductService : IProductService
    {

        private readonly ProductDbContext _productDbContext;
        private readonly TransactionDbContext _transactionDbContext;
        //EVAL: would ordinarily have configured a logging provider and injected throughout; provider would route to appinsights & other required outputs
        private ILogger _logger { get; set; }

        public ProductService(IServiceProvider services)
        {
            _productDbContext = services.GetRequiredService<ProductDbContext>();
            _transactionDbContext = services.GetRequiredService<TransactionDbContext>();
        }

        public async Task<ProductGetResponse> GetProduct(ProductGetRequest request)
        {
            ProductGetResponse response = new ProductGetResponse();

            //EVAL: business logic would go here; NOT IMPLEMENTED
            throw new NotImplementedException();

            return response;
        }
    }
}
