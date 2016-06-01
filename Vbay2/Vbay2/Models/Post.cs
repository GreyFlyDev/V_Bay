using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vbay2.Models
{
    public class Post
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AdID { get; set; }
        public bool Approved { get; set; }

        public virtual User User { get; set; }
        public virtual Ad Ad { get; set; }
    }
}