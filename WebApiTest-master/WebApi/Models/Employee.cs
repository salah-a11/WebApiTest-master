using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Mobile { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
