using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected double Salary { get; set; }

        public Role Role { get; set; }

        public Employee (string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }

        public void PrintInfo ()
        {
            Console.WriteLine($"The employee {FirstName} {LastName} ");
            Console.WriteLine($"Have {Salary} salary");
        }

        public virtual double GetSalary()
        {
            return Salary;
        } 
    }
}
