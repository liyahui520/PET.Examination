using Abp.Authorization;
using PET.Examination.Authorization.Roles;
using PET.Examination.Authorization.Users;

namespace PET.Examination.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
