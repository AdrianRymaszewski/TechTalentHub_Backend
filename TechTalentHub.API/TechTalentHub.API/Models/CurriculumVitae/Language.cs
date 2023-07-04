namespace TechTalentHub.API.Models.CurriculumVitae
{
    public class Language
    {
        public int Id { get; set; }

        public string LanguageName { get; set; }
        public string Level { get; set; }

        public int CurriculumVitaeId { get; set; }
        public CurriculumVitae CurriculumVitae { get; set; }
    }
}
