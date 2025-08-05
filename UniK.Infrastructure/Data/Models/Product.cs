using System.ComponentModel.DataAnnotations;
using UniK.Infrastructure.Constants;

namespace UniK.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxDescriptionLength)]
        public string ImageUrl { get; set; } = string.Empty;

        // Navigation properties
        public ICollection<FeedingConveyor> FeedingConveyors { get; set; } = new List<FeedingConveyor>();
        public ICollection<Doser> Dosers { get; set; } = new List<Doser>();
        public ICollection<CompleteSolution> CompleteSolutions { get; set; } = new List<CompleteSolution>();
        public ICollection<Bag> Bags { get; set; } = new List<Bag>();
    }
}