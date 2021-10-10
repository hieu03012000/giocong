using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class Company
    {
        public Company()
        {
            Departments = new HashSet<Department>();
            Employees = new HashSet<Employee>();
            PayPeriods = new HashSet<PayPeriod>();
            PaySchedules = new HashSet<PaySchedule>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PayPeriod> PayPeriods { get; set; }
        public virtual ICollection<PaySchedule> PaySchedules { get; set; }
    }
}
