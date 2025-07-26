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
        public string Model { get; set; }

        public ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();

        // Common Specs
        public string Construction { get; set; }
        public string Productivity { get; set; }
        public string OverallDimensions { get; set; }
        public string Weight { get; set; }
        public string Interface { get; set; }
        public string Driving { get; set; }
        [Required]
        public string ElectricalSupply { get; set; }
        [Required]
        public string InstalledPower { get; set; }
        [Required]
        public string CompressedAirConsumption { get; set; }
        public string Electronics { get; set; }
    }
}
