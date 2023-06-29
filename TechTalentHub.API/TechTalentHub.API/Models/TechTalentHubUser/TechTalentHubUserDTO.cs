using System.ComponentModel.DataAnnotations;

namespace TechTalentHub.API.Models.TechTalentHubUser
{
    public class TechTalentHubUserDTO : TechTalentHubLoginDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}
