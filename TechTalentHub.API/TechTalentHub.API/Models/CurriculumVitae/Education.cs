using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace TechTalentHub.API.Models.CurriculumVitae
{
    public class Education
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Details { get; set; }

        public int CurriculumVitaeId { get; set; }
        public CurriculumVitae CurriculumVitae { get; set; }
    }
}
