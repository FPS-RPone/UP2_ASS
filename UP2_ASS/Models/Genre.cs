using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP2_ASS.Models
{
    public class Genre
    {
        public int GenreId {  get; set; }
        [MaxLength(100)]
        public string? GenreName { get; set; }
    }
}
