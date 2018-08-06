using System;

namespace CrossSolar.Domain
{
    public class OneHourElectricity
    {
        public int Id { get; set; }

        public string PanelId { get; set; }

        public long KiloWatt { get; set; }

        public DateTime DateTime { get; set; }
    }
}