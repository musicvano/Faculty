using System;

namespace Fit.Models
{
    public class Relative
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Appartment { get; set; }
        public string Phone { get; set; }
    }
}