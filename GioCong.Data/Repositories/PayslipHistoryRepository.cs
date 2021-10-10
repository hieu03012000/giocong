using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IPayslipHistoryRepository :IBaseRepository<PayslipHistory>
    {
    }
    public partial class PayslipHistoryRepository :BaseRepository<PayslipHistory>, IPayslipHistoryRepository
    {
         public PayslipHistoryRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

