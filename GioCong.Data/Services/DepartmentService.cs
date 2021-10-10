using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IDepartmentService:IBaseService<Department>
    {
    }
    public partial class DepartmentService:BaseService<Department>,IDepartmentService
    {
        public DepartmentService(IDepartmentRepository repository):base(repository){}
    }
}
