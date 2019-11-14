using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PET.Examination.Authorization.Roles;
using PET.Examination.Authorization.Users;
using PET.Examination.MultiTenancy;

namespace PET.Examination.EntityFrameworkCore
{
    public class ExaminationDbContext : AbpZeroDbContext<Tenant, Role, User, ExaminationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExaminationDbContext(DbContextOptions<ExaminationDbContext> options)
            : base(options)
        {
        }
    }
}
