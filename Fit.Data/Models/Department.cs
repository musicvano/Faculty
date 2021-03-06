﻿using System;

namespace Fit.Data.Models
{
    /// <summary>
    /// The department of the faculty
    /// </summary>
    public class Department
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Department name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Department name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// Department short name
        /// </summary>
        public string Acronym { get; set; }

        /// <summary>
        /// The logo of the department
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Official website URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Official email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The faculty that department belongs to
        /// </summary>
        public Faculty Faculty { get; set; }
    }
}