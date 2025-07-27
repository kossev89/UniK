using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public abstract class Doser: ProductBase
    {
        public ICollection<PackagingMachine> PackagingMachines { get; set; } = new List<PackagingMachine>();
    }
}
