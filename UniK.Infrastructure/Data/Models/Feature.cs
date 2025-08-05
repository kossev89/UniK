using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniK.Infrastructure.Constants;

namespace UniK.Infrastructure.Data.Models
{
    public class Feature
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.MaxFeatureNameLength)]
        public string Label { get; set; } = string.Empty; // e.g., "Compact design", "Speed"

        [MaxLength(DataConstants.MaxFeatureNameLength)]
        public string Value { get; set; } = string.Empty; // e.g., "Up to 30 bpm"

        [StringLength(20)]
        public string Unit { get; set; } = string.Empty; // e.g., "mm", "bpm"

        public int? DisplayOrder { get; set; }

        [ForeignKey("Group")]
        public int? GroupId { get; set; }

        public FeatureGroup Group { get; set; } = new FeatureGroup(); // Navigation property to the group

        public ICollection<Feature> ProductFeatures { get; set; } = new List<Feature>();
    }
}