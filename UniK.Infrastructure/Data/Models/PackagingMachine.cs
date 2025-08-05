using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniK.Infrastructure.Data.Models;
using UniK.Infrastructure.Constants;

namespace UniK.Infrastructure.Data.Models
{
    public class PackagingMachine : ProductBase
    {
        [Required]
        public int MaxFilmWidth { get; set; }
        [Required]
        public int MinFilmWidth { get; set; }

        [Required]
        public int MinFilmThickness { get; set; }
        [Required]
        public int MaxFilmThickness { get; set; }

        [Required]
        public int MinBagLength { get; set; }
        [Required]
        public int MaxBagLength { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.MaxFilmMaterialLength)]
        public string FilmMaterial { get; set; } = string.Empty;
        public ICollection<Doser> CompatibleDosers { get; set; } = new List<Doser>();
        public ICollection<Bag> BagTypes { get; set; } = new List<Bag>();
        public ICollection<ExtraMachine> Extras { get; set; } = new List<ExtraMachine>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();
    }
}