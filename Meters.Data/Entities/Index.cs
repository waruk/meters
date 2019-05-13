using System;

namespace Meters.Data.Entities
{
    public class Index
    {
        public int IndexId { get; set; }
        public DateTime RegisteredDate { get; set; }
        public double Value { get; set; }

        public int MeterId { get; set; }
        public Meter Meter { get; set; }      // reference to the meter this index is linked to
    }
}
