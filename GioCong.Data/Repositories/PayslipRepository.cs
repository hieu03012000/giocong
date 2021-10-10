using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IPayslipRepository :IBaseRepository<Payslip>
    {
    }
    public partial class PayslipRepository :BaseRepository<Payslip>, IPayslipRepository
    {
         public PayslipRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

