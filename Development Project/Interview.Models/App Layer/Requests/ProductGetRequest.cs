using Interview.Models.App_Layer.Responses;
using Interview.Models.DTO_Objects;
using MediatR;

namespace Interview.Models.App_Layer.Requests
{
    public class ProductGetRequest : IRequest<ProductGetResponse>
    {
        public Product Product { get; set; }
    }
}
