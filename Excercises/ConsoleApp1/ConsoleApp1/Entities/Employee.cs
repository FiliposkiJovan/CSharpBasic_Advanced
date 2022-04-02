using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DayOfWeek WorkingDay { get; set; }

        protected double _saraly;

        public Employee(int id, string firstName, string lastName, DayOfWeek workingDay)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            WorkingDay = workingDay;
        }

        public void SetSalary(double salary)
        {
            _saraly = salary;
        }

        public virtual void DoWork()
        {
            Console.WriteLine($"{FirstName} {LastName} is doing work");
        }

        public virtual double GetSalary()
        {
            return _saraly;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
    }
}
