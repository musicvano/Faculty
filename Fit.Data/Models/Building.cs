using System;

namespace Fit.Data.Models
{
    public class Building
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Street Street { get; set; }

        public string House { get; set; }

        public string Postcode { get; set; }
    }
}