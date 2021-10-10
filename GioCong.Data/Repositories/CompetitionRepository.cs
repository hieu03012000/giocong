using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface ICompetitionRepository :IBaseRepository<Competition>
    {
    }
    public partial class CompetitionRepository :BaseRepository<Competition>, ICompetitionRepository
    {
         public CompetitionRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

