namespace TechTalentHub.API.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public DateTime PostedDate { get; set; }
        public int YearsOfExperience { get; set; }
        public RemoteWorkType TypeOfWork { get; set; }
    }

    
}
