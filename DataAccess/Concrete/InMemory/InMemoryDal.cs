using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : IMemoryDal
    {
        List<Car> _car;
        public InMemoryDal()
        {
            _car = new List<Car>
            {
                new Car{Id = 1, BrandId = 2,ColorId= 1,DailyPrice= 15000, Description = "Jeep" , ModelYear = "2001"},
                new Car{Id = 2, BrandId = 4,ColorId= 2,DailyPrice= 16000, Description = "Mercedes" , ModelYear = "2008"},
                new Car{Id = 3, BrandId = 5,ColorId= 1,DailyPrice= 19000, Description = "Ford" , ModelYear = "2022"},
                new Car{Id = 4, BrandId = 2,ColorId= 2,DailyPrice= 11000, Description = "Jeep" , ModelYear = "2021"},
                new Car{Id = 5, BrandId = 3,ColorId= 4,DailyPrice= 12000, Description = "Honda" , ModelYear = "2018"},
                new Car{Id = 6, BrandId = 3,ColorId= 3,DailyPrice= 16000, Description = "Toyota" , ModelYear = "2016"}
            };

        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car cartToDelete = _car.SingleOrDefault (p => p.Id == car.Id); // foreach LİNQ
            _car.Remove(cartToDelete);
        }

            public List<Car> GetAll()
            {
                return _car;
            }

        public List<Car> GetAllModelYear(string modelYear)
        {
            return _car.Where(p => p.ModelYear == modelYear).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id); // foreach LİNQ
            
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
