using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class GravityFallMetalDetector
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
        public ICollection<Video> Videos { get; set; } = new List<Video>();
        // Common Specs
        [MaxLength(Constants.DataConstants.MaxConstructionLength)]
        public string Construction { get; set; } = string.Empty;

        [Required]
        public int DetectionDiameter { get; set; }

        [Required]
        public int DetectionSpeed { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxDetectionSensitivityLength)]
        public string DetectionSensitivity { get; set; } = string.Empty;

        [MaxLength(Constants.DataConstants.MaxOutputSignalLength)]
        public string OutputSignal { get; set; } = string.Empty;
        [MaxLength(Constants.DataConstants.MaxOverallDimensionsLength)]
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

        [MaxLength(Constants.DataConstants.MaxRejectorLength)]
        public string Rejector { get; set; } = string.Empty;
    }
}
