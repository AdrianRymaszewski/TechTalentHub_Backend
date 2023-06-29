using Microsoft.AspNetCore.Identity;

namespace TechTalentHub.API.Data
{
    public class TechTalentHubUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
