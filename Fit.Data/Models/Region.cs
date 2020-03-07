using System;

namespace Fit.Data.Models
{
    /// <summary>
    /// Region (state) of the country
    /// </summary>
    public class Region
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
    }
}