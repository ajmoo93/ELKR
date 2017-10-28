using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesting2.Models
{
    public class PersonViewModel
    {
        public Guid PersonID { get; set; }
        public int PersonNumber { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
    }
}