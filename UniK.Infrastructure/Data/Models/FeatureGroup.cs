using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniK.Infrastructure.Constants;
namespace UniK.Infrastructure.Data.Models
{
    public class FeatureGroup
    {
        [Key]
        [Required]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.MaxFeatureNameLength)]
        public string Name { get; set; } = string.Empty; // e.g., "Electrical", "Construction", etc.

        public ICollection<Feature> Features { get; set; } = new List<Feature>();
    }
}
