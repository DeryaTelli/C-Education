using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Construction
{
     class Car
    {
        public string model;
        public string name;
        public int year;
      
        public Car(string modelName , string createName , int modelYear)  // class ísmleri ayni olmali kurucu class ile 
        {
            model=modelName;
            name=createName;
            year=modelYear;
        }
        static void Main(string[] args)
        {
            Car ford = new Car("Ford", "Derya", 2002);
            Console.WriteLine(ford.model+" "+ford.name+" "+ford.year);
            Console.ReadLine();
        }
    }
}
