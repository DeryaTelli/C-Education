using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4InheritanceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.honk();
            Console.WriteLine(car.brand+ " "+car.modelName);
            Console.ReadLine();
        }
    }
}
