using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IAccountService:IBaseService<Account>
    {
    }
    public partial class AccountService:BaseService<Account>,IAccountService
    {
        public AccountService(IAccountRepository repository):base(repository){}
    }
}
