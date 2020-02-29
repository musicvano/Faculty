﻿namespace Fit.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Acronym { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Faculty Faculty { get; set; }
    }
}