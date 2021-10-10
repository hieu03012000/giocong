using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IAccountRepository :IBaseRepository<Account>
    {
    }
    public partial class AccountRepository :BaseRepository<Account>, IAccountRepository
    {
         public AccountRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

