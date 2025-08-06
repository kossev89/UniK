using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniK.Infrastructure.Data.Models.Bases;

namespace UniK.Infrastructure.Data.Models
{
    public class RotaryTable : AuxuliaryEquipment
    {
        [Required]
        public int RotatingSpeed { get; set; }
    }
}
