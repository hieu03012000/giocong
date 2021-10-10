using GioCong.Data.Models;
using GioCong.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;
namespace GioCong.Data.Repositories
{
    public partial interface IDepartmentRepository :IBaseRepository<Department>
    {
    }
    public partial class DepartmentRepository :BaseRepository<Department>, IDepartmentRepository
    {
         public DepartmentRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

