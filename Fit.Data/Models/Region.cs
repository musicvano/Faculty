﻿using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    /// <summary>
    /// The region (state) of the country
    /// </summary>
    public class Region
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Region name in Ukrainian
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Region name in English
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// The country that region belongs to
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Localities of the the region
        /// </summary>
        public List<Locality> Localities { get; set; }
    }
}