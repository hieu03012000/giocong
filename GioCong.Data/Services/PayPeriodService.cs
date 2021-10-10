using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IPayPeriodService:IBaseService<PayPeriod>
    {
    }
    public partial class PayPeriodService:BaseService<PayPeriod>,IPayPeriodService
    {
        public PayPeriodService(IPayPeriodRepository repository):base(repository){}
    }
}
