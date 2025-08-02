using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public abstract class Doser : ProductBase
    {
        public ICollection<PackagingMachine> CompatiblePackagingMachines { get; set; } = new List<PackagingMachine>();
        public ICollection<Product> SuitableProducts { get; set; } = new List<Product>();
        public ICollection<Extra> Extras { get; set; } = new List<Extra>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();
        [Required]
        [MaxLength(Constants.DataConstants.MaxHopperCapacityLength)]
        public string HopperCapacity { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxDosingRangeLength)]
        public string DosingRange { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxWeighingAccuracyLength)]
        public string WeighingAccuracy { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxWorkingPrincipleLength)]
        public string WorkingPrinciple { get; set; } = string.Empty;
    }
}
