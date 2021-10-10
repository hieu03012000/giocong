using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IAdvancedPaymentService:IBaseService<AdvancedPayment>
    {
    }
    public partial class AdvancedPaymentService:BaseService<AdvancedPayment>,IAdvancedPaymentService
    {
        public AdvancedPaymentService(IAdvancedPaymentRepository repository):base(repository){}
    }
}
