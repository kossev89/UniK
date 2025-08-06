using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniK.Infrastructure.Data.Models.Bases;

namespace UniK.Infrastructure.Data.Models
{
    public class ExtraConveyor : ExtraBase
    {
        public ICollection<FeedingConveyor> FeedingConveyors { get; set; } = new List<FeedingConveyor>();
    }
}
