using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IPayAdvancedService:IBaseService<PayAdvanced>
    {
    }
    public partial class PayAdvancedService:BaseService<PayAdvanced>,IPayAdvancedService
    {
        public PayAdvancedService(IPayAdvancedRepository repository):base(repository){}
    }
}
