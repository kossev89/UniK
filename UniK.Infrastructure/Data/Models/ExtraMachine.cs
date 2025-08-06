using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniK.Infrastructure.Data.Models.Bases;

namespace UniK.Infrastructure.Data.Models
{
    public class ExtraMachine: ExtraBase
    {
        public ICollection<PackagingMachine> Machines { get; set; } = new List<PackagingMachine>();
    }
}
