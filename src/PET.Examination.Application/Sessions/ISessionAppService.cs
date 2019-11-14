using System.Threading.Tasks;
using Abp.Application.Services;
using PET.Examination.Sessions.Dto;

namespace PET.Examination.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
