using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(int id, string firstName, string lastName, DayOfWeek workingDay,string department) : base(id, firstName, lastName, workingDay)
        {
            Department = department;
        }

        public void ReadReports()
        {
            Console.WriteLine($"The manager {FirstName} is reading reports");
        }

        public void ModifyWorkingHours()
        {
            Console.WriteLine($"The manager {FirstName} is modifying the working hours");
        }
    }
}
