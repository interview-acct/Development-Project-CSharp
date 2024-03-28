using System;
using System.ComponentModel.DataAnnotations;

namespace Interview.Database.DAL_Objects
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public Guid RecordGuid { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
