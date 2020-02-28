using System;

namespace Fit.Models
{
    public class Parent
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Country { get; set; }
        public int Region { get; set; }
        public int City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Appartment { get; set; }
        public string Phone { get; set; }
    }
}