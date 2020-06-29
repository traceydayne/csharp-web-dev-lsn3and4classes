using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string studentName, int studentId, int numberOfCredits, double gpa)
        {
            this.Name = studentName;
            this.StudentId = studentId;
            this.NumberOfCredits = numberOfCredits;
            this.Gpa = gpa;
        }
    }
}
