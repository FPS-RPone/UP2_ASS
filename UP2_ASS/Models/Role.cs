using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP2_ASS.Models
{
    internal class Role
    {
        public int RoleId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public int? RolePower { get; set; }
    }
}
