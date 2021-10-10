using System;
using System.Collections.Generic;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class AdvancedPayment
    {
        public Guid Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        public Guid? PayAdvancedId { get; set; }

        public virtual PayAdvanced PayAdvanced { get; set; }
    }
}
