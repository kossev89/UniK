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
        public int BeltWidth { get; set; }
        [Required]
        public int BeltLength { get; set; }
        [Required]
        [MaxLength(Constants.DataConstants.MaxBeltMaterialLength)]
        public string BeltMaterial { get; set; } = string.Empty;
        [Required]
        public int Speed { get; set; }
    }
}
