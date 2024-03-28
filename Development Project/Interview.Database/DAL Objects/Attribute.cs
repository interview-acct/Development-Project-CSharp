using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Database.DAL_Objects
{
    public class Attribute : Record
    {
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
    }
}
