﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tut3.Models
{
    public class Student
    {
        
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }

        public Enrollment enrollment { get; set; }

    }
}
