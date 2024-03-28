using Interview.Models.App_Layer.Requests;
using Interview.Models.App_Layer.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Interfaces
{
    public interface IProductService
    {
        public Task<ProductGetResponse> GetProduct(ProductGetRequest request);
    }
}
