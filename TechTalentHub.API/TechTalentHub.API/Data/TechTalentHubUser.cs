using Microsoft.AspNetCore.Identity;
using TechTalentHub.API.Models.CurriculumVitae;

namespace TechTalentHub.API.Data
{
    public class TechTalentHubUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<CurriculumVitae>? CurriculumVitaes { get; set; }
    }
}
