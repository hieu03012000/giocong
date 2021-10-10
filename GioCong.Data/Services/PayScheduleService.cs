using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface IPayScheduleService:IBaseService<PaySchedule>
    {
    }
    public partial class PayScheduleService:BaseService<PaySchedule>,IPayScheduleService
    {
        public PayScheduleService(IPayScheduleRepository repository):base(repository){}
    }
}
