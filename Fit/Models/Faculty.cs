using System.Collections.Generic;

namespace Fit.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public List<Department> Departments { get; set; }
    }
}