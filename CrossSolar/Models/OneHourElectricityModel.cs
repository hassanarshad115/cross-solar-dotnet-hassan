using System;

namespace CrossSolar.Models
{
    public class OneHourElectricityModel
    {
        public int Id { get; set; }

        public long KiloWatt { get; set; }

        public DateTime DateTime { get; set; }
    }
}