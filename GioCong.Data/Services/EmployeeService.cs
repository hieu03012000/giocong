using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IEmployeeService:IBaseService<Employee>
    {
    }
    public partial class EmployeeService:BaseService<Employee>,IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repository):base(repository){}
    }
}
