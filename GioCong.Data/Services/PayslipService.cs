using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IPayslipService:IBaseService<Payslip>
    {
    }
    public partial class PayslipService:BaseService<Payslip>,IPayslipService
    {
        public PayslipService(IPayslipRepository repository):base(repository){}
    }
}
