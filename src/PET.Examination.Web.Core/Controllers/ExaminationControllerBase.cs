using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PET.Examination.Controllers
{
    public abstract class ExaminationControllerBase: AbpController
    {
        protected ExaminationControllerBase()
        {
            LocalizationSourceName = ExaminationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
