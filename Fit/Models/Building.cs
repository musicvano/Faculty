namespace Fit.Models
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string PostCode { get; set; }
    }
}