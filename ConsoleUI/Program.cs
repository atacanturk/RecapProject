using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.GetById(2);
            Console.WriteLine("aaa");
            foreach (var product in carManager.GetAllByModelYear(1978))
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.BrandId);
                Console.WriteLine(product.DailyPrice);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.ModelYear);
                Console.Write("*****************");

            }

            Car newCar = new Car()
            {
                Id = 5,
                BrandId = 5,
                DailyPrice = 400,
                ModelYear = 2018,
                Description = "Tesla Model S"
            };
            carManager.Add(newCar);
            carManager.Delete(newCar);
        }
    }
}
