using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCar());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name: " + car.CarName+"\n" + "Car Model: " + car.CarModel+"\n" + "Car Type: " + car.CarType+"\n" + "Model Year: " + car.ModelYear+"\n" + 
                    "Car Colour: " + car.ColorId+"\n" + "Car Engine: " + car.CarEngine + "\n" + "Car Price: EUR " + car.UnitPrice + "\n" + "Car Stock: " + car.UnitsInStock);

            }

            
        }
    }
}
