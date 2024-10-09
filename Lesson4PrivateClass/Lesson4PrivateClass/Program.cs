using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4PrivateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1= new Person();
            person1.Name="Liam";
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            person1.SurName="telli";
            Console.WriteLine(person1.SurName);
            Console.ReadLine();
        }
    }
}
