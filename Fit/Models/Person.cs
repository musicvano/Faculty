using System;

namespace Fit.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EngFirstName { get; set; }
        public string EngMiddleName { get; set; }
        public string EngLastName { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public long TaxId { get; set; }
        public int Country { get; set; }
        public int Region { get; set; }
        public int City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Appartment { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Telegram { get; set; }
    }
}