using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IPlanTypeRepository :IBaseRepository<PlanType>
    {
    }
    public partial class PlanTypeRepository :BaseRepository<PlanType>, IPlanTypeRepository
    {
         public PlanTypeRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

