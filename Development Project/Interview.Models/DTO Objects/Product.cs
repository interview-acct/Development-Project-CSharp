using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models.DTO_Objects
{
    public class Product : Record
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public List<Category> Categories { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
