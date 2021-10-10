using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IPayPeriodRepository :IBaseRepository<PayPeriod>
    {
    }
    public partial class PayPeriodRepository :BaseRepository<PayPeriod>, IPayPeriodRepository
    {
         public PayPeriodRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

