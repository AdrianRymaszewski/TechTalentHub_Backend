namespace TechTalentHub.API.Models.CurriculumVitae
{
    public class Network
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Link { get; set; }

        public int CurriculumVitaeId { get; set; }
        public CurriculumVitae CurriculumVitae { get; set; }
    }
}
