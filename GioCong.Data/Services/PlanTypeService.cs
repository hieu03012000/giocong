using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IPlanTypeService:IBaseService<PlanType>
    {
    }
    public partial class PlanTypeService:BaseService<PlanType>,IPlanTypeService
    {
        public PlanTypeService(IPlanTypeRepository repository):base(repository){}
    }
}
