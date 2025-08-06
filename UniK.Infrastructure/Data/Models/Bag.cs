using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using UniK.Infrastructure.Data.Models.Bases;

namespace UniK.Infrastructure.Data.Models
{
    public class Bag
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
        [MaxLength(Constants.DataConstants.MaxTitleLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxDescriptionLength)]
        public string Description { get; set; } = string.Empty;
        public ICollection<PackagingMachine> CompatibleMachines { get; set; } = new List<PackagingMachine>();
        public ICollection<ExtraBag> Extras { get; set; } = new List<ExtraBag>();
        public ICollection<Product> SuitableProducts { get; set; } = new List<Product>();
    }
}