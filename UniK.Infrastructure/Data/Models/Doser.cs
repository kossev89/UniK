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
        public ICollection<ExtraDoser> Extras { get; set; } = new List<ExtraDoser>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();
        [Required]
        public int HopperCapacity { get; set; }
        [Required]
        public int MinimumDose { get; set; }
        [Required]
        public int MaximumDose { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxWeighingAccuracyLength)]
        public string WeighingAccuracy { get; set; } = string.Empty;

        [Required]
        [MaxLength(Constants.DataConstants.MaxWorkingPrincipleLength)]
        public string WorkingPrinciple { get; set; } = string.Empty;
    }
}
