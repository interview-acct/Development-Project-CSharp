using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models.DTO_Objects
{
    public class Attribute : Record
    {
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
    }
}
