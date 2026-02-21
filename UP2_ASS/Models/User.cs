using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP2_ASS.Models
{
    internal class User
    {
        public int UserId { get; set; }
        [MaxLength(100)]
        public string? UserName { get; set; }
        [MaxLength (100)]
        public string? Password { get; set; }
        public Role? Role { get; set; }
        public int? RolePower {  get; set; }
    }
}
