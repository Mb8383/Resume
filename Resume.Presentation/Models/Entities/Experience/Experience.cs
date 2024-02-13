namespace Resume.Presentation.Models.Entities.Experience
{
    public class Experience
    {
        public int id { get; set; }
        public string ExperienceTitle { get; set; }
        public string ExperienceDuration { get; set;}
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string? CompanySite { get; set;}
    }
}
