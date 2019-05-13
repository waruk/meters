using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meters.Data.Entities
{
    public class Index
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IndexId { get; set; }

        [Required]
        public DateTime RegisteredDate { get; set; }

        [Required]
        public double Value { get; set; }

        public int MeterId { get; set; }

        [ForeignKey("MeterId")]
        public Meter Meter { get; set; }      // reference to the meter this index is linked to
    }
}
