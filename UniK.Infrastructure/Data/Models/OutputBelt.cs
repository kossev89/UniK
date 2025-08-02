using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class OutputBelt : AuxuliaryEquipment
    {
        [Required]
        [MaxLength(Constants.DataConstants.MaxBeltWidthLength)]
        public string BeltWidth { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxBeltLengthLength)]
        public string BeltLength { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxBeltMaterialLength)]
        public string BeltMaterial { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxSpeedLength)]
        public string Speed { get; set; } = string.Empty;
    }
}
