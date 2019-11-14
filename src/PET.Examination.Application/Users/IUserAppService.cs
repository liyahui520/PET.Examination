using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PET.Examination.Roles.Dto;
using PET.Examination.Users.Dto;

namespace PET.Examination.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
