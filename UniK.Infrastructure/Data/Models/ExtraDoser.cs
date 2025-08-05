using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class ExtraDoser : ExtraBase
    {
        public ICollection<Doser> Dosers { get; set; } = new List<Doser>();
    }
}
