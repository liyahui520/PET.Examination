using System.Threading.Tasks;
using PET.Examination.Configuration.Dto;

namespace PET.Examination.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
