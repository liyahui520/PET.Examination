using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PET.Examination.EntityFrameworkCore
{
    public static class ExaminationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExaminationDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExaminationDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
