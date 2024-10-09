using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4ClassExample
{
    class Car
    {
        string model;
        string color;
        int year;
        static void Main(string[] args)
        {
            Car ford = new Car();
            ford.model="Mustang";
            ford.color="red";
            ford.year=1996;

            Car Opel =new Car();
            Opel.model="Astra";
            Opel.color="white";
            Opel.year=2000;
            Console.WriteLine(ford.model+" " + ford.color+ " "  + ford.year);
            Console.WriteLine(Opel.model +" " + Opel.color+" " + Opel.year);
            Console.ReadLine(); 
        }
    }
}
