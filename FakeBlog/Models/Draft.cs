using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Draft
    {
        public int DraftId { get; set; }
        public bool IsPublished { get; set; }
    }
}