using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace TechTalentHub.API.Models.CurriculumVitae
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? Details { get; set; }

        public int CurriculumVitaeId { get; set; }
        public CurriculumVitae CurriculumVitae { get; set; }
    }
}
