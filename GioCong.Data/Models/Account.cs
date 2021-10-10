using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? EmpId { get; set; }
        public string Type { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
