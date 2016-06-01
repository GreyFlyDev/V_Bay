using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VbayTest.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Email { get; set;}
        public string Phone { get; set; }
        public int AdID { get; set; }

        public virtual ICollection<Ad>Ad { get; set; }
    }
}