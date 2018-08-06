using System.ComponentModel.DataAnnotations;

namespace CrossSolar.Domain
{
    public class Panel
    {
        public int Id { get; set; }

        [Required] public double Latitude { get; set; }

        public double Longitude { get; set; }

        [Required] public string Serial { get; set; }

        public string Brand { get; set; }
    }
}