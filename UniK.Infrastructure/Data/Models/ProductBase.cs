using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    [Comment("Base class for all products, containing common properties and specifications. This class is not intended to be instantiated directly, but rather serves as a base for specific product types. It includes properties that are common across different product types, such as construction, productivity, dimensions, weight, interface, driving mechanism, electrical supply, installed power, compressed air consumption, and electronics.")]
    public abstract class ProductBase
    {
        [Key]
        public int Id { get; init; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxModelLength)]
        public string Model { get; set; }

        public ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();

        // Common Specs
        [MaxLength(Constants.DataConstants.MaxConstructionLength)]
        public string Construction { get; set; }
        [MaxLength(Constants.DataConstants.MaxProductivityLength)]
        public string Productivity { get; set; }
        [MaxLength(Constants.DataConstants.MaxOverallDimensionsLength)]
        public string OverallDimensions { get; set; }
        [MaxLength(Constants.DataConstants.MaxWeightLength)]
        public string Weight { get; set; }
        [MaxLength(Constants.DataConstants.MaxInterfaceLength)]
        public string Interface { get; set; }
        [MaxLength(Constants.DataConstants.MaxDrivingLength)]
        public string Driving { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxElectricalSupplyLength)]
        public string ElectricalSupply { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxInstalledPowerLength)]
        public string InstalledPower { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxCompressedAirConsumptionLength)]
        public string CompressedAirConsumption { get; set; }
        [MaxLength(Constants.DataConstants.MaxElectronicsLength)]
        public string Electronics { get; set; }
    }
}
