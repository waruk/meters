using System.Collections.Generic;

namespace Meters.Data.Entities
{
    public class Meter
    {
        public int MeterId { get; set; }
        public string SerialNumber { get; set; }
        public MeteredResource ResourceType { get; set; }
        public MeterLocation Location { get; set; }
        public ICollection<Index> Indexes { get; set; } = new List<Index>();    // good idea to initialize it to prevent null reference exceptions
    }
}
