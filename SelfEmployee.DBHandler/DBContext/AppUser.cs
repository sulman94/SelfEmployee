using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SelfEmployee.DBHandler.DBContext;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    public AppUser()
    {

    }
    public bool IsActive { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public long? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}

