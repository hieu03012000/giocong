using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IEmployeeRepository :IBaseRepository<Employee>
    {
    }
    public partial class EmployeeRepository :BaseRepository<Employee>, IEmployeeRepository
    {
         public EmployeeRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

