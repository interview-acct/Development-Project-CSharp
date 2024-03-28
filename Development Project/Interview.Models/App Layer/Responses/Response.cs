using Interview.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Models.App_Layer.Responses
{
    public class Response<T> : IApiResponse<T>
    {
        public List<object> RelatedEndpoints { get; set; }
        public T Data { get; set; }
    }
}
