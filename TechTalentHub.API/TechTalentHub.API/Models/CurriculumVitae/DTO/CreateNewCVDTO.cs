using System.ComponentModel.DataAnnotations;

namespace TechTalentHub.API.Models.CurriculumVitae.DTO
{
    public class CreateNewCVDTO
    {
        [Required]
        public string TechTalentHubUserId { get; set; }
        [Required]
        public string CurriculumVitaename { get; set; }
    }
}
