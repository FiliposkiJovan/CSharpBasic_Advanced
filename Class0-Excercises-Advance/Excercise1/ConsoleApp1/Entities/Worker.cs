using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Worker : Employee
    {
        public Worker(int id, string firstName, string lastName, DayOfWeek workingDay) : base(id, firstName, lastName, workingDay)
        {
        }

        public void WriteReport()
        {
            Console.WriteLine($"{FirstName} is writing a report");
        }
    }
}
