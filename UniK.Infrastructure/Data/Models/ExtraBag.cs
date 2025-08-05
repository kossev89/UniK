using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class ExtraBag: ExtraBase
    {
        public ICollection<Bag> Bags { get; set; } = new List<Bag>();
    }
}
