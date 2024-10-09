using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Class
{
    internal class Program
    { class Car
        {
            public string color = "red";// public yapinca program class icerisinden erisim saglayabildim 
            public int maxSpeed = 200;
            public void fullThottle()
            {
                Console.WriteLine("The car is going as fast as it can!");
            }

        }
   
        static void Main(string[] args)
        {
            Car car = new Car(); // nesne olusturdum car classi icin 
            Console.WriteLine(car.color);
            Console.WriteLine(car.maxSpeed);
            car.fullThottle(); // class incindeki methodu bu sekilde cagirabiliriz 
            Console.ReadLine(); 
        }
    }
}
