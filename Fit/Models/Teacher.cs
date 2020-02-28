namespace Fit.Models
{
    public class Teacher: Person
    {
        public Position Position { get; set; }
        public Department Department { get; set; }
        public Degree Degree { get; set; }
        public Rank Rank { get; set; }
        public string OrcidId { get; set; }
        public string ScopusId { get; set; }
        public string ScholarId { get; set; }
        public string Bio { get; set; }
    }
}