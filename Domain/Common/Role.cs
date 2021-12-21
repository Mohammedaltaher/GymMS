using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace Domain.Common
{
    public enum AppRoleEnum{
        [Description("Admin")]
        Admin = 1 ,
        [Description("User")]
        User = 2 
    }
    public class Role : IdentityRole
    {

    }
}
