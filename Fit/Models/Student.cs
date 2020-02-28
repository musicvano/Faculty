namespace Fit.Models
{
    public class Student: Person
    {
        public Funding Funding { get; set; }
        public StudyForm StudyForm { get; set; }
        public Status Status { get; set; }
        public Parent Mother { get; set; }
        public Parent Father { get; set; }
        public Group Group { get; set; }
        public Specialty Specialty { get; set; }
    }
}