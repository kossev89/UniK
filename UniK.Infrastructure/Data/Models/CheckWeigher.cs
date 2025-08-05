using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class CheckWeigher: ProductBase
    {
        public ICollection<Video> Videos { get; set; } = new List<Video>();
        [Required]
        public int MinWeight { get; set; }
        [Required]
        public int MaxWeight { get; set; }
        [Required]
        public int Accuracy { get; set; }
        [Required]
        public int MaxProductLength { get; set; }
        [Required]
        public int MaxProductWidth { get; set; }
        public int BeltWidth { get; set; }
        [MaxLength(Constants.DataConstants.MaxRejectorLength)]
        public string Rejector { get; set; } = string.Empty;
    }
}
