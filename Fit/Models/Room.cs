namespace Fit.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public Building Building { get; set; }
    }
}