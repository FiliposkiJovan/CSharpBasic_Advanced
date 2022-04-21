using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue;

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName, 500, Role.Sales)
        {
           
        }
        
        public void AddSuccessRevenue(double number)
        {
            _successSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if ( _successSaleRevenue>2000 && _successSaleRevenue<=5000)
            {
                return Salary + 1000;
            }
            else if (_successSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            return Salary;
        }

    }
}
