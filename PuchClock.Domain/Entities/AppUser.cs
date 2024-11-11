using Microsoft.AspNetCore.Identity;
using PunchClock.Database.Domain;

namespace PuchClock.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<ClientUserMapping> ClientUserMapping { get; set; }

    }

    public class AppUserRole : IdentityRole
    {
        public AppUserRole(string name) : base(name)
        {

        }
    }
}
