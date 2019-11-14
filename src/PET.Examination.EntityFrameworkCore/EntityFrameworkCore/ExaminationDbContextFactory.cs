using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PET.Examination.Configuration;
using PET.Examination.Web;

namespace PET.Examination.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ExaminationDbContextFactory : IDesignTimeDbContextFactory<ExaminationDbContext>
    {
        public ExaminationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ExaminationDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ExaminationDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ExaminationConsts.ConnectionStringName));

            return new ExaminationDbContext(builder.Options);
        }
    }
}
