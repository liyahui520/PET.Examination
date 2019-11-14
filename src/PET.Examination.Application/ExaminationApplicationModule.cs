using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PET.Examination.Authorization;

namespace PET.Examination
{
    [DependsOn(
        typeof(ExaminationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExaminationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExaminationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExaminationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
