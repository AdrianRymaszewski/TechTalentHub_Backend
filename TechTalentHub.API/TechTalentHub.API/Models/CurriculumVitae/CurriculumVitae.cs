using System.ComponentModel.DataAnnotations;
using TechTalentHub.API.Data;
namespace TechTalentHub.API.Models.CurriculumVitae
{
    public class CurriculumVitae
    {
        public int Id { get; set; }
        public string? CurriculumVitaename { get; set; }
        public string? Strengths { get; set; }
        public string? SelfDefinition { get; set; } 
        public PersonalData? PersonalData { get; set; }

        public List<Education>? Education { get; set; }

        public List<WorkExperience>? WorkExperience { get; set; }

        public List<Skill>? Skills { get; set; }
        public List<Language>? Languages { get; set; }
        public List<Network>? Networks { get; set; }
    }
}
