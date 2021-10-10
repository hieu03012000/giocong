using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IAdvancedPaymentRepository :IBaseRepository<AdvancedPayment>
    {
    }
    public partial class AdvancedPaymentRepository :BaseRepository<AdvancedPayment>, IAdvancedPaymentRepository
    {
         public AdvancedPaymentRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

