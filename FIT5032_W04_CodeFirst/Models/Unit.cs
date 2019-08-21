using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class Unit
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public virtual Student Student { get; set; }
    }
}