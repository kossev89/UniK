using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniK.Infrastructure.Data.Models
{
    public class FeedingConveyor: ProductBase
    {
        public ICollection<Product> SuitableProducts { get; set; } = new List<Product>();
        public ICollection<Extra> Extras { get; set; } = new List<Extra>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();
    }
}
