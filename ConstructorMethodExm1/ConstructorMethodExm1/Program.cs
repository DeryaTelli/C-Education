using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodExm1
{
    internal class Program
    {
        class Person
        {
            public string Name;
            public int Age;

            //parametresiz constructor method
            public Person()
            {
                Name = "Bilinmiyor";
                Age = 0;
            }

            //parametreli constructor 
            public Person(string name , int age)
            {
                Name = name;
                Age=age;
            }
            public void PersonInfo()
            {
                Console.WriteLine("Name: "+Name+ " Age: "+Age);
            }
        }

        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.PersonInfo();
            Person p =new Person("Derya",22);
            p.PersonInfo();
            Console.ReadLine();
        }
    }
}
