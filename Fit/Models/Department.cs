namespace Fit.Models
{
    public class Department
    {
        public int Id { get; set; }
        /// <summary>
        /// Abbreviation of the department
        /// </summary>
        public string Acronym { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
    }
}