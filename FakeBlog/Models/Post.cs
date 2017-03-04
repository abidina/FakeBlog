using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DatePublished { get; set; }
        public string Content { get; set; }
        public bool IsDraft { get; set; }
        public string URL { get; set; }

    }
}