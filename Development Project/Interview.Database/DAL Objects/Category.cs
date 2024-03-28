using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Database.DAL_Objects
{
    public class Category : Record
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
