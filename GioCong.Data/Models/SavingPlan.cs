using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class SavingPlan
    {
        public SavingPlan()
        {
            SavingItems = new HashSet<SavingItem>();
        }

        public Guid Id { get; set; }
        public Guid? CreateUser { get; set; }
        public decimal? SalaryPerMonth { get; set; }
        public Guid? SavingAccount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Guid? PlanTypeId { get; set; }
        public Guid? Competition { get; set; }

        public virtual Competition CompetitionNavigation { get; set; }
        public virtual Employee CreateUserNavigation { get; set; }
        public virtual PlanType PlanType { get; set; }
        public virtual ICollection<SavingItem> SavingItems { get; set; }
    }
}
