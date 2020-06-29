using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string CourseName { get; set; }
        public Dictionary<string, string> VocabularyTerms { get; set; }

        public List<Student> ClassRoster { get; set; }

        public double ClassAverage { get; set; }

        public Course (string courseName, List<Student> classRoster)
        {
            this.CourseName = courseName;
            this.ClassRoster = classRoster;
        }

    }
}
