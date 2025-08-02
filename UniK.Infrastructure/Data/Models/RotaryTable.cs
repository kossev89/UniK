using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class RotaryTable : AuxuliaryEquipment
    {
        [Required]
        [MaxLength(Constants.DataConstants.MaxRotatingSpeedLength)]
        public string RotatingSpeed { get; set; } = string.Empty;
    }
}
