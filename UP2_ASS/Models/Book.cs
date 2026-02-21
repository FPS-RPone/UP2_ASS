using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP2_ASS.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        [MaxLength(250)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Authors { get; set; }
        public int? Year { get; set; }
        [MaxLength(100)]
        public string? GenreName { get; set; }
        public Genre? Genre { get; set; }
        [MaxLength(50)]
        public string? StatusName { get; set; }
        public Status? Status { get; set; }
        public User? User { get; set; }
    }
}
