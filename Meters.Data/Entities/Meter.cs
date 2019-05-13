using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meters.Data.Entities
{
    public class Meter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MeterId { get; set; }

        [MaxLength(50)]
        public string SerialNumber { get; set; }

        [Required]
        public MeteredResource ResourceType { get; set; }

        [Required]
        public MeterLocation Location { get; set; }

        public ICollection<Index> Indexes { get; set; } = new List<Index>();    // good idea to initialize it to prevent null reference exceptions
    }
}
