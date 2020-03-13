using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    /// <summary>
    /// The faculty of the university
    /// </summary>
    public class Faculty
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Faculty name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Faculty name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// Faculty short name (abbreviation)
        /// </summary>
        public string Acronym { get; set; }

        /// <summary>
        /// The university that faculty belongs to
        /// </summary>
        public University University { get; set; }

        /// <summary>
        /// Departments of the faculty
        /// </summary>
        public List<Department> Departments { get; set; }
    }
}