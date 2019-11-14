using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PET.Examination.MultiTenancy.Dto;

namespace PET.Examination.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

