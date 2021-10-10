using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class EmployeeDepartment
    {
        public Guid EmpId { get; set; }
        public Guid DepId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Status { get; set; }
        public Guid Id { get; set; }

        public virtual Department Dep { get; set; }
        public virtual Employee Emp { get; set; }
    }
}
