using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Database.DAL_Objects
{
    public class Transaction : Record
    {
        public Guid ProductGuid { get; set; }
        public string TransactionType { get; set; }
        public int TransactionQuantity { get; set; }
    }
}
