using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IPayAdvancedRepository :IBaseRepository<PayAdvanced>
    {
    }
    public partial class PayAdvancedRepository :BaseRepository<PayAdvanced>, IPayAdvancedRepository
    {
         public PayAdvancedRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

