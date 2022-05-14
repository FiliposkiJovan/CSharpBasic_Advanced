using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Services.Services.Interfaces
{
    public interface IMenagerService
    {
        List<Driver> GetAllDrivers();
        List<Car> GetAllCars();
        void AssignDriver(Driver driver, Car car, Shift shift);
        void UnAssignDriver(Driver driver);
        Driver GetDriverById(int id);
        Car GetCarById(int id);
        List<Driver> GetAllAssignDrivers();
        List<Driver> GetAllUnAssignDrivers();


    }
}
