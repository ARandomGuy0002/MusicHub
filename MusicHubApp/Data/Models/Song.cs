using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum GenreType
    {
        Blues, Rap, PopMusic, Rock, Jazz
    }
    public class Song
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public GenreType Genre { get; set; }
        [Required]
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        [Required]
        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ICollection<SongPerformer> SongPerformers { get; set; } = new HashSet<SongPerformer>();
    }

}
