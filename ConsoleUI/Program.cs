using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description+" Model aracın fiyatı "+car.DailyPrice);
                Console.WriteLine("---------------------------");
            }

            
        }
    }
}
