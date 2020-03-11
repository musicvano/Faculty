using System;

namespace Fit.Data.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public Street Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }
}