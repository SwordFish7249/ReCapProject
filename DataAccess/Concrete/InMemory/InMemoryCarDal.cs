﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, CarName ="Toyota", CarModel = "Camry", CarEngine = "1800CC", CarType = "Hybrid Sedan", ModelYear = "2020", CarColour = "White Snow", UnitPrice = 25000, UnitsInStock = 20},
                new Car{Id = 2, BrandId = 1, CarName ="Toyota", CarModel = "Corona", CarEngine = "1800CC", CarType = "Hybrid Sedan", ModelYear = "2020", CarColour = "White Snow", UnitPrice = 20000, UnitsInStock = 22},
                new Car{Id = 3, BrandId = 2, CarName ="Toyota", CarModel = "GR YARİS", CarEngine = "1600CC", CarType = "Racing Hatchback", ModelYear = "2021", CarColour = "Brown", UnitPrice = 35000, UnitsInStock = 2},
                new Car{Id = 4, BrandId = 2, CarName ="Toyota", CarModel = "Corolla HB", CarEngine = "1800CC", CarType = "Hybrid Hatchback", ModelYear = "2021", CarColour = "Fire Red", UnitPrice = 15000, UnitsInStock = 40},
                new Car{Id = 5, BrandId = 3, CarName ="Toyota", CarModel = "CHR", CarEngine = "1800CC", CarType = "Hybrid SUV", ModelYear = "2020", CarColour = "Silver", UnitPrice = 30000, UnitsInStock = 30},
                new Car{Id = 6, BrandId = 3, CarName ="Toyota", CarModel = "RAV4", CarEngine = "2500CC", CarType = "Hybrid SUV", ModelYear = "2020", CarColour = "White Snow", UnitPrice = 40000, UnitsInStock = 24},
                new Car{Id = 7, BrandId = 4, CarName ="Toyota", CarModel = "Supra", CarEngine = "(2JZ) 3000CC", CarType = "Performance Car", ModelYear = "2002", CarColour = "Fire Red", UnitPrice = 55000, UnitsInStock = 4},
                new Car{Id = 8, BrandId = 4, CarName ="Toyota", CarModel = "Celica", CarEngine = "2400CC", CarType = "Performance Car", ModelYear = "2004", CarColour = "Fire Red", UnitPrice = 45000, UnitsInStock = 4},
                new Car{Id = 9, BrandId = 5, CarName ="Toyota", CarModel = "LAND CRUISER", CarEngine = "5700CC", CarType = "Jeep", ModelYear = "2021", CarColour = "Black", UnitPrice = 50000, UnitsInStock = 1},
                new Car{Id = 10, BrandId = 6, CarName ="Toyota", CarModel = "HILUX", CarEngine = "2755CC", CarType = "Pickup", ModelYear = "2021", CarColour = "Black", UnitPrice = 52000, UnitsInStock = 1}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.CarModel = car.CarModel;
            carToUpdate.CarEngine = car.CarEngine;
            carToUpdate.CarType = car.CarType;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.CarColour = car.CarColour;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.UnitPrice = car.UnitPrice;
            carToUpdate.UnitsInStock = car.UnitsInStock;
        }
    }
}
