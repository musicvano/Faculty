using System.Collections.Generic;

namespace Fit.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Acronim { get; set; }
        public List<Student> Students { get; set; }
    }
}