using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class Payslip
    {
        public Payslip()
        {
            PayAdvanceds = new HashSet<PayAdvanced>();
            PayslipHistories = new HashSet<PayslipHistory>();
        }

        public Guid Id { get; set; }
        public Guid? EmpId { get; set; }
        public decimal? TotalSalary { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? PayslipHistoryId { get; set; }
        public Guid? SalaryPeriodId { get; set; }

        public virtual Employee Emp { get; set; }
        public virtual PayPeriod SalaryPeriod { get; set; }
        public virtual ICollection<PayAdvanced> PayAdvanceds { get; set; }
        public virtual ICollection<PayslipHistory> PayslipHistories { get; set; }
    }
}
