using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IPayslipHistoryService:IBaseService<PayslipHistory>
    {
    }
    public partial class PayslipHistoryService:BaseService<PayslipHistory>,IPayslipHistoryService
    {
        public PayslipHistoryService(IPayslipHistoryRepository repository):base(repository){}
    }
}
