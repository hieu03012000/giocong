using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IPayScheduleRepository :IBaseRepository<PaySchedule>
    {
    }
    public partial class PayScheduleRepository :BaseRepository<PaySchedule>, IPayScheduleRepository
    {
         public PayScheduleRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

