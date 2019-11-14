using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PET.Examination.Configuration;

namespace PET.Examination.Web.Host.Startup
{
    [DependsOn(
       typeof(ExaminationWebCoreModule))]
    public class ExaminationWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ExaminationWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExaminationWebHostModule).GetAssembly());
        }
    }
}
