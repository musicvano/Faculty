using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    /// <summary>
    /// The country of the world
    /// </summary>
    public class Country
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Two-letter country code defined in ISO 3166-1
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Country name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// Regions of the country
        /// </summary>
        public List<Region> Regions { get; set; }
    }
}