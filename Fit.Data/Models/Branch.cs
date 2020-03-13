using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    /// <summary>
    /// The branch of knowledge
    /// </summary>
    public class Branch
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Branch code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Branch name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Branch name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// Specialties of the branch
        /// </summary>
        public List<Specialty> Specialties { get; set; }
    }
}