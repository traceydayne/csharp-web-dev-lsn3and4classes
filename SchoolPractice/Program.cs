using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Tracey = new Student("Tracey", 12345, 1, 4.0);
            Console.WriteLine(Tracey.Name);

            List<Student> classList = new List<Student>() { Tracey };
            Course CodeCamp = new Course("Code Camp", classList);
            Console.WriteLine(CodeCamp.CourseName);

            Teacher Ben = new Teacher("Ben", "Clark", "Code Camp", 1);

            Console.WriteLine(Ben.FirstName + " " + Ben.LastName);
            
        }
    }
}
