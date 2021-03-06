﻿using System;

namespace Fit.Data.Models
{
    /// <summary>
    /// The specialty, program subject area in higher education
    /// </summary>
    public class Specialty
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Specialty code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Specialty name in ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specialty name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// The branch that the specialty belongs to
        /// </summary>
        public Branch Branch { get; set; }
    }
}