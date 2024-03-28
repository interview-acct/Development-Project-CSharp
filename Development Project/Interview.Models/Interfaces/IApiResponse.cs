using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Models.Interfaces
{
    public interface IApiResponse<T>
    {
        List<object> RelatedEndpoints { get; set; }
        T Data { get; set; }
    }
}
