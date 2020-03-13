using System;

namespace Fit.Data.Models
{
    public class Building
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public Address Address { get; set; }
        public University University { get; set; }
    }
}