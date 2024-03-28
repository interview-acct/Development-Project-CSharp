using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models.DTO_Objects
{
    public class Transaction : Record
    {
        public Guid ProductGuid { get; set; }
        public string TransactionType { get; set; }
        public int TransactionQuantity { get; set; }
    }
}
