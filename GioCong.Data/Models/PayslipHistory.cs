using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class PayslipHistory
    {
        public Guid Id { get; set; }
        public Guid? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? PayslipId { get; set; }
        public decimal? SalaryAmount { get; set; }
        public Guid? UpdateId { get; set; }
        public double? UpToDateWorkingHour { get; set; }
        public decimal? MaxAdvanceAmount { get; set; }

        public virtual Payslip Payslip { get; set; }
    }
}
