using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PET.Examination.Configuration.Dto;

namespace PET.Examination.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExaminationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
