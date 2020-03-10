using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    /// <summary>
    /// The locality (city, town, village) of the district
    /// </summary>
    public class Locality
    {
        public Guid Id { get; set; }

        /// <summary>
        /// City name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Locality name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// The region that locality belongs to
        /// </summary>
        public Region Region { get; set; }

        /// <summary>
        /// Streets of the locality
        /// </summary>
        public List<Street> Streets { get; set; }
    }
}