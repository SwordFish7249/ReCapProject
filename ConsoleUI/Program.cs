using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCar());
            CarTest(carManager);

            //BrandTest();

            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColor());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrand());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if(result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Car Name: " + car.CarName + "\n" + "Car Brand: " + car.BrandName + "\n" +
                        "Car Colour: " + car.ColorName + "\n" + "Car Price: EUR " + car.UnitPrice + "\n" );

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
