using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSoapService.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }

    }
}