using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class SavingItem
    {
        public Guid Id { get; set; }
        public int? Ox { get; set; }
        public int? Oy { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public Guid? SavingPlanId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual SavingPlan SavingPlan { get; set; }
    }
}
