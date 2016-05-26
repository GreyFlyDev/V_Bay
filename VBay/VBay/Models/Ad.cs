using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace VBay.Models
{
    public class Ad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdId { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public bool? Approved { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}