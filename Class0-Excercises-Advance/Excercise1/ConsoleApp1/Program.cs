using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(2, "Ivan", "Djikovski",DayOfWeek.Saturday);
            Worker worker = new Worker(3, "Miki", "Dimovski", DayOfWeek.Monday);
            Director director = new Director(4, "Jovan", "Filiposki", DayOfWeek.Tuesday);
            Manager manager = new Manager(6, "Petko", "Petkovski", DayOfWeek.Friday, "HR");
            Contractor contractor = new Contractor(5, "Stranko", "Stankovski", DayOfWeek.Wednesday, 40, 10, manager);

            employee.DoWork();
            worker.DoWork();
            director.DoWork();

            Console.WriteLine($"{contractor.FirstName} {contractor.GetSalary()}");

            List<Employee> company = new List<Employee>() { new Contractor(1, "Dragan","G", DayOfWeek.Wednesday, 12.5,5,manager),
                                                            new Contractor(7, "Stojko","A", DayOfWeek.Friday, 10.5,5,manager),
                                                            new Manager(8, "Stefan","P", DayOfWeek.Thursday, "HR"),
                                                            new Manager(9, "Nikola", "F", DayOfWeek.Sunday, "HR")};

            CEO ceo = new CEO(10, "Bill", "Gates", DayOfWeek.Friday, 100, 1000, company);

            Console.WriteLine(ceo);
            ceo.PrintEmpoyee();
            Console.WriteLine(ceo.GetSalary());
        }
    }
}
