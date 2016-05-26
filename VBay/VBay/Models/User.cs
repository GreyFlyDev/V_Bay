using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBay.Models
{
    public class User
    {
        //Typically and Entity Correspond to a DB Table Row
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}