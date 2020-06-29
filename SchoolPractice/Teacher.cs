﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Subject { get; set; }

        public int YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
            this.YearsTeaching = yearsTeaching;
        }
    }
}
