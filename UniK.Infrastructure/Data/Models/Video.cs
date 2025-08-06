using System.ComponentModel.DataAnnotations;
using UniK.Infrastructure.Constants;

namespace UniK.Infrastructure.Data.Models
{
    public class Video
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxFeatureNameLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxImagePathLength)]
        public string VideoUrl { get; set; } = string.Empty;
 
    }
}