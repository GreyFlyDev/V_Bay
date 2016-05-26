using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBay.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int AdId { get; set; }

        public virtual User User { get; set; }
        public virtual Ad Ad { get; set; }

    }
}