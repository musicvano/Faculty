using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
        public List<Student> Students { get; set; }
    }
}