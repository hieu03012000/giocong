using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IEmployeeDepartmentRepository :IBaseRepository<EmployeeDepartment>
    {
    }
    public partial class EmployeeDepartmentRepository :BaseRepository<EmployeeDepartment>, IEmployeeDepartmentRepository
    {
         public EmployeeDepartmentRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

