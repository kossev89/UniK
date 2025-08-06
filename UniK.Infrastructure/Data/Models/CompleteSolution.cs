using System.ComponentModel.DataAnnotations;
using UniK.Infrastructure.Constants;
using UniK.Infrastructure.Data.Models.Bases;

namespace UniK.Infrastructure.Data.Models
{
    public class CompleteSolution
    {
        [Key]
        [Required]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.MaxFeatureNameLength)]
        public string Name { get; init; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.MaxImagePathLength)]
        public string ImageUrl { get; init; } = string.Empty;

        public int? PackagingMachineId { get; set; }
        public PackagingMachine PackagingMachine { get; set; }

        public int? DoserId { get; set; }
        public Doser Doser { get; init; }

        public int? ConveyorId { get; set; }
        public FeedingConveyor Conveyor { get; init; }

        public ICollection<AuxuliaryEquipment> AuxuliaryEquipment { get; init; } = new List<AuxuliaryEquipment>();

        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Feature> Features { get; init; } = new List<Feature>();

    }
}