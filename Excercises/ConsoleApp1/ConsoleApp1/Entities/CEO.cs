using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class CEO : Employee
    {
        public List<Employee> Employees { get; set; }

        public int Shares { get; set; }

        private double _sharesPrice;

        public CEO (int id, string firstName, string lastName, DayOfWeek workingDay,int shares, double sharesPrice, List<Employee> employess) : 
                                                                                                      base(id,firstName,lastName, workingDay)
        {
            Shares = shares;
            Employees = employess;
            _sharesPrice = sharesPrice;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            _sharesPrice = sharesPrice;
        }

        public void PrintEmpoyee()
        {
            /*foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee);
            }*/
            Employees.ForEach(Console.WriteLine);
        }

        public override double GetSalary()
        {
            return _saraly + Shares * _sharesPrice;
        }
    }
}
