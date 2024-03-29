﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonContosoNVC5
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Nullable<Grades>  Grade { get; set; }

        public Course Course { get; set; }

       public Student Student { get; set; }
    }

    public enum Grades
    {
        A,
        B,
        C,
        D,
        E,
        F,
    }
}
