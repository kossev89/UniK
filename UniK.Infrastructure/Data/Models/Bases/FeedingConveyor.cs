using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniK.Infrastructure.Constants;

namespace UniK.Infrastructure.Data.Models.Bases
{
    public class FeedingConveyor: ProductBase
    {
        public ICollection<Product> SuitableProducts { get; set; } = new List<Product>();
        public ICollection<ExtraConveyor> Extras { get; set; } = new List<ExtraConveyor>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();
        [Required]
        [MaxLength(DataConstants.MaxConveyorTypeLength)]
        public string? ConveyorType { get; set; }
    }
}
