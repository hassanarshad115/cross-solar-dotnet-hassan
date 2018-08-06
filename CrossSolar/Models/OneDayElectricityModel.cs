using System;

namespace CrossSolar.Domain
{
    public class OneDayElectricityModel
    {
        public double Sum { get; set; }

        public double Average { get; set; }

        public double Maximum { get; set; }

        public double Minimum { get; set; }

        public DateTime DateTime { get; set; }
    }
}