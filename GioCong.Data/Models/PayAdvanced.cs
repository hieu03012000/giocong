using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class PayAdvanced
    {
        public PayAdvanced()
        {
            AdvancedPayments = new HashSet<AdvancedPayment>();
        }

        public Guid Id { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? PayslipId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Status { get; set; }

        public virtual Payslip Payslip { get; set; }
        public virtual ICollection<AdvancedPayment> AdvancedPayments { get; set; }
    }
}
