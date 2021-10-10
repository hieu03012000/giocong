using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class PlanType
    {
        public PlanType()
        {
            SavingPlans = new HashSet<SavingPlan>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContentJson { get; set; }

        public virtual ICollection<SavingPlan> SavingPlans { get; set; }
    }
}
