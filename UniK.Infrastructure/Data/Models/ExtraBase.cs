using System.ComponentModel.DataAnnotations;

namespace UniK.Infrastructure.Data.Models
{
    public abstract class ExtraBase
    {
        [Key]
        [Required]
        public int Id { get; init; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxModelLength)]
        public string Model { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxImagePathLength)]
        public string ImagePath { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxDescriptionLength)]
        public string Description { get; set; } = string.Empty;
    }
}