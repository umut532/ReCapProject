using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        IMemoryDal  _memoryDal;

        public CarManager(IMemoryDal memoryDal)
        {
            _memoryDal = memoryDal;
        }
        public List<Car> GetAll()
        {
            return _memoryDal.GetAll();
        }
    }
}
