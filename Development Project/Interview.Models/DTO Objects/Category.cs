using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models.DTO_Objects
{
    public class Category : Record
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
