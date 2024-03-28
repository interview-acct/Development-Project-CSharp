using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Database.DAL_Objects
{
    public class Product : Record
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public List<Category> Categories { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
