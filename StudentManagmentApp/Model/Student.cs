using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentApp.Model
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string className { get; set; }
        public int rollNo { get; set; }
        public float Result { get; set; }
        public string Email { get; set; }
    }
}