using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class Competition
    {
        public Competition()
        {
            SavingPlans = new HashSet<SavingPlan>();
        }

        public Guid Id { get; set; }
        public Guid? SavingPlan1 { get; set; }
        public Guid? SavingPlan2 { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }

        public virtual ICollection<SavingPlan> SavingPlans { get; set; }
    }
}
