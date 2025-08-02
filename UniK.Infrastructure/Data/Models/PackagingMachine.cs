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
        [MaxLength(Constants.DataConstants.MaxFilmWidthLength)]
        public string FilmWidth { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxFilmThicknessLength)]
        public string FilmThickness { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxBagLengthLength)]
        public string BagLength { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.DataConstants.MaxFilmMaterialLength)]
        public string FilmMaterial { get; set; } = string.Empty;
        public ICollection<Doser> CompatibleDosers { get; set; } = new List<Doser>();
        public ICollection<Bag> BagTypes { get; set; } = new List<Bag>();
        public ICollection<Extra> Extras { get; set; } = new List<Extra>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();
    }
}