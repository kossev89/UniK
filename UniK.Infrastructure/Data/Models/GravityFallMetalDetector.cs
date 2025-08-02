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
        public ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();
        // Common Specs
        [MaxLength(Constants.DataConstants.MaxConstructionLength)]
        public string Construction { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxDetectionDiameterLength)]
        public string DetectionDiameter { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxDetectionSpeedLength)]
        public string DetectionSpeed { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxDetectionSensitivityLength)]
        public string DetectionSensitivity { get; set; } = string.Empty;

        [MaxLength(Constants.DataConstants.MaxOutputSignalLength)]
        public string OutputSignal { get; set; } = string.Empty;
        [MaxLength(Constants.DataConstants.MaxOverallDimensionsLength)]
        public string OverallDimensions { get; set; } = string.Empty;


        [MaxLength(Constants.DataConstants.MaxWeightLength)]
        public string Weight { get; set; } = string.Empty;


        [MaxLength(Constants.DataConstants.MaxInterfaceLength)]
        public string Interface { get; set; } = string.Empty;


        [MaxLength(Constants.DataConstants.MaxDrivingLength)]
        public string Driving { get; set; } = string.Empty;


        [Required]
        [MaxLength(Constants.DataConstants.MaxElectricalSupplyLength)]
        public string ElectricalSupply { get; set; } = string.Empty;


        [Required]
        [MaxLength(Constants.DataConstants.MaxInstalledPowerLength)]
        public string InstalledPower { get; set; } = string.Empty;


        [Required]
        [MaxLength(Constants.DataConstants.MaxCompressedAirConsumptionLength)]
        public string CompressedAirConsumption { get; set; } = string.Empty;


        [MaxLength(Constants.DataConstants.MaxElectronicsLength)]
        public string Electronics { get; set; } = string.Empty;

        [MaxLength(Constants.DataConstants.MaxRejectorLength)]
        public string Rejector { get; set; } = string.Empty;
    }
}
