using System;

namespace Fit.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FirstNameEn { get; set; }
        public string MiddleNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public string TaxId { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Appartment { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Telegram { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }
        public Degree Degree { get; set; }
        public Rank Rank { get; set; }
        public string OrcidId { get; set; }
        public string ScopusId { get; set; }
        public string ScholarId { get; set; }
        public string Bio { get; set; }
    }
}