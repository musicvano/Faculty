using System;

namespace Fit.Data.Models
{
    public class Country
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Two-letter country code defined in ISO 3166-1
        /// </summary>
        public string Code { get; set; }
        public string Name { get; set; }
    }
}