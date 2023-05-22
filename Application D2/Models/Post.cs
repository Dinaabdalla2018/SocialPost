using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_D2.Models
{
    public  class Post
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string title { get; set; }
        [StringLength(50)]
        public string? bref { get; set; }
        [MaxLength(100)]
        public string desc { get; set; }
        public DateTime date_ { get; set; }
        [ForeignKey("author")]
        public int author_id { get; set; }
        [ForeignKey("blog")]
        public int blog_id { get; set; }

        public virtual Author author { set; get; }
        public virtual Blog? blog { get; set; }
    }
}

