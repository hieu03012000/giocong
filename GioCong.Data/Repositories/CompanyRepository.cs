using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface ICompanyRepository :IBaseRepository<Company>
    {
    }
    public partial class CompanyRepository :BaseRepository<Company>, ICompanyRepository
    {
         public CompanyRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

