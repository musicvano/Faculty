using System;
using System.Collections.Generic;

namespace Fit.Data.Models
{
    public class Student
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
        public Locality City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Telegram { get; set; }
        public string GradeBook { get; set; }        
        public Funding Funding { get; set; }
        public Study Study { get; set; }
        public Status Status { get; set; }
        public List<Relative> Relatives { get; set; }
        public Group Group { get; set; }
        public Specialty Specialty { get; set; }
    }
}