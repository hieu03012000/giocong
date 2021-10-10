using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface ISavingItemService:IBaseService<SavingItem>
    {
    }
    public partial class SavingItemService:BaseService<SavingItem>,ISavingItemService
    {
        public SavingItemService(ISavingItemRepository repository):base(repository){}
    }
}
