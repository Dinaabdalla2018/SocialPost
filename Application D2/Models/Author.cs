using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_D2.Models
{
    public class Author
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [Column(TypeName = "image")]
        public byte[]? photo { get; set; }
        public int? Age { get; set; }

        public virtual List<Post> posts { get; set; } = new List<Post>();

    }
}

