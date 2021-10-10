using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface ISavingPlanService:IBaseService<SavingPlan>
    {
    }
    public partial class SavingPlanService:BaseService<SavingPlan>,ISavingPlanService
    {
        public SavingPlanService(ISavingPlanRepository repository):base(repository){}
    }
}
