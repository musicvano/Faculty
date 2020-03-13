using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    /// <summary>
    /// The university, institution or academy
    /// </summary>
    public class University
    {
        public Guid Id { get; set; }

        /// <summary>
        /// University name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// University name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// Official university address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// The logo of the university
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Fax number
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Official website URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Official email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Buildings of the university
        /// </summary>
        public List<Building> Buildings { get; set; }

        /// <summary>
        /// Faculties of the university
        /// </summary>
        public List<Faculty> Faculties { get; set; }
    }
}