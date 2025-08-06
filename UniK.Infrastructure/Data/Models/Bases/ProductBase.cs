using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models.Bases
{
    [Comment("Base class for all products, containing common properties and specifications. This class is not intended to be instantiated directly, but rather serves as a base for specific product types. It includes properties that are common across different product types, such as construction, productivity, dimensions, weight, interface, driving mechanism, electrical supply, installed power, compressed air consumption, and electronics.")]
    public abstract class ProductBase
    {
        [Key]
        public int Id { get; init; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxModelLength)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxImagePathLength)]
        public string ImagePath { get; set; } = string.Empty;

        public ICollection<Feature> ProductFeatures { get; set; } = new List<Feature>();

        // Common Specs
        [MaxLength(Constants.DataConstants.MaxConstructionLength)]
        public string Construction { get; set; } = string.Empty;

        public int Productivity { get; set; }
        public int OverallLength { get; set; }
        public int OverallWidth { get; set; }
        public int OverallHeight { get; set; }
        public int Weight { get; set; }

        [MaxLength(Constants.DataConstants.MaxInterfaceLength)]
        public string Interface { get; set; } = string.Empty;

        [MaxLength(Constants.DataConstants.MaxDrivingLength)]
        public string Driving { get; set; } = string.Empty;

        [Required]
        public int ElectricalVoltage { get; set; }
        [Required]
        public int ElectricalFrequency { get; set; }

        [Required]
        public int InstalledPower { get; set; }

        [Required]
        public int CompressedAirConsumption { get; set; }

        [MaxLength(Constants.DataConstants.MaxElectronicsLength)]
        public string Electronics { get; set; } = string.Empty;
    }
}
