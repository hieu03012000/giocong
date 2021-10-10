using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Accounts = new HashSet<Account>();
            EmployeeDepartments = new HashSet<EmployeeDepartment>();
            Payslips = new HashSet<Payslip>();
            SavingPlans = new HashSet<SavingPlan>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public Guid? CompanyId { get; set; }
        public string Status { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual ICollection<Payslip> Payslips { get; set; }
        public virtual ICollection<SavingPlan> SavingPlans { get; set; }
    }
}
