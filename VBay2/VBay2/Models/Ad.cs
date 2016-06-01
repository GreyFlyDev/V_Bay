using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vbay2.Models
{
    public class Ad
    {
        public int ID { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DatePosted { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
    }
}