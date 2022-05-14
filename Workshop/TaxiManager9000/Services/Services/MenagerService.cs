using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Services.Services.Interfaces;
using TaxiManager9000.Shared;

namespace TaxiManager9000.Services.Services
{
    public class MenagerService : IMenagerService
    {
        private readonly ICarDatabase _carDatabase;
        private readonly IDriverDatabase _driverDatabase;

        public MenagerService()
        {
            _carDatabase = DependencyResolver.GetService<ICarDatabase>();
            _driverDatabase = DependencyResolver.GetService<IDriverDatabase>();
        }
        public List<Car> GetAllCars()
        {
            List<Car> cars = _carDatabase.GetAll();
            return cars;
        }

        public List<Driver> GetAllDrivers()
        {
            List<Driver> drivers = _driverDatabase.GetAll();
            return drivers;
        }
        public Car GetCarById(int id)
        {
            return GetAllCars().FirstOrDefault(x => x.Id == id);
        }

        public Driver GetDriverById(int id)
        {
            return GetAllDrivers().FirstOrDefault(x => x.Id == id);
        }

        public void AssignDriver(Driver driver, Car car, Shift shift)
        {
            throw new NotImplementedException();
        }
        public void UnAssignDriver(Driver driver)
        {
            throw new NotImplementedException();
        }

        public List<Driver> GetAllAssignDrivers()
        {
            throw new NotImplementedException();
        }

        public List<Driver> GetAllUnAssignDrivers()
        {
            throw new NotImplementedException();
        }

    }
}
