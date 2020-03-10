using System;

namespace Fit.Data.Models
{
    /// <summary>
    /// The street (square, lane, cul-de-sac, microdistrict) of the locality
    /// </summary>
    public class Street
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Street name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Street name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// The locality that street belongs to
        /// </summary>
        public Locality Locality { get; set; }
    }
}