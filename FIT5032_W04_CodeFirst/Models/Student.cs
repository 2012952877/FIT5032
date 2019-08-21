using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class Student
    {
        public int id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public List<Unit> Units { get; set; }
    }
}