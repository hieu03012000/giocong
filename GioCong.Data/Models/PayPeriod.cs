using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class PayPeriod
    {
        public PayPeriod()
        {
            Payslips = new HashSet<Payslip>();
        }

        public Guid Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Period { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Payslip> Payslips { get; set; }
    }
}
