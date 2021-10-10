using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface ISavingPlanRepository :IBaseRepository<SavingPlan>
    {
    }
    public partial class SavingPlanRepository :BaseRepository<SavingPlan>, ISavingPlanRepository
    {
         public SavingPlanRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

