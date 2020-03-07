using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    public class Faculty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public List<Department> Departments { get; set; }
    }
}