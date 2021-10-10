using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IEmployeeDepartmentService:IBaseService<EmployeeDepartment>
    {
    }
    public partial class EmployeeDepartmentService:BaseService<EmployeeDepartment>,IEmployeeDepartmentService
    {
        public EmployeeDepartmentService(IEmployeeDepartmentRepository repository):base(repository){}
    }
}
