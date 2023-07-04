using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace TechTalentHub.API.Models.CurriculumVitae
{
    public class Skill
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CurriculumVitaeId { get; set; }
        public CurriculumVitae CurriculumVitae { get; set; }
    }
}
