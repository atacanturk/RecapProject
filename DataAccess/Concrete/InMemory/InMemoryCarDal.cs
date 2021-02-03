using DataAccess.Abstract;
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
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1, DailyPrice=210, ModelYear=2019, Description="4 Kişilik Dizel Kırmızı Mercedes."},
                new Car{Id=2, BrandId=1, DailyPrice=220, ModelYear=2020, Description="8 Kişilik Dizel Vip Mercedes."},
                new Car{Id=3, BrandId=2, DailyPrice=190, ModelYear=2018, Description="5 Kişilik Benzinli Kırmızı BMW."},
                new Car{Id=4, BrandId=3, DailyPrice=150, ModelYear=1997, Description="Faça Şahin"},
                new Car{Id=5, BrandId=4, DailyPrice=100, ModelYear=1978, Description="Azrailin Makam Aracı-Katil Reno"},
            };       
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByModelYear(int year) //Model yılına göre
        {
            return _cars.Where(c => c.ModelYear == year).ToList();
        }

        public Car GetById(int id) // id numarası ile 
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
