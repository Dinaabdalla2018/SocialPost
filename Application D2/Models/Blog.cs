using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_D2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string? Desc { get; set; }

        public virtual List<Post> posts { get; set; } = new List<Post>();
    }
}
