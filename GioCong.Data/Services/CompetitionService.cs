using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface ICompetitionService:IBaseService<Competition>
    {
    }
    public partial class CompetitionService:BaseService<Competition>,ICompetitionService
    {
        public CompetitionService(ICompetitionRepository repository):base(repository){}
    }
}
