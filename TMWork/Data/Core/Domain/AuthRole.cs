using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TMWork.Data.Core.Domain
{
    public class AuthRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
