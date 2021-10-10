using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class PaySchedule
    {
        public Guid Id { get; set; }
        public string Frequency { get; set; }
        public DateTime? AnchorPayDate { get; set; }
        public DateTime? FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
