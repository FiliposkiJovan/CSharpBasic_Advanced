using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises2.Entities
{
    public class Student : Users
    {
        public Subject Subject { get; set; }

        public List<int> Grades { get; set; }

        public Student(string username, string password, Subject subject, List<int> grades) : base(username,password)
        {
            Subject = subject;
            Grades = grades;
        }


    }
}
