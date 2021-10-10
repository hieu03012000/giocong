using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface ISavingItemRepository :IBaseRepository<SavingItem>
    {
    }
    public partial class SavingItemRepository :BaseRepository<SavingItem>, ISavingItemRepository
    {
         public SavingItemRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

