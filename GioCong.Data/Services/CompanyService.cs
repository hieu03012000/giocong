using GioCong.Data.Models;
using GioCong.Data.Repositories;
using GioCong.Data.Services.Base;

namespace GioCong.Data.Services
{
    public partial interface ICompanyService:IBaseService<Company>
    {
    }
    public partial class CompanyService:BaseService<Company>,ICompanyService
    {
        public CompanyService(ICompanyRepository repository):base(repository){}
    }
}
