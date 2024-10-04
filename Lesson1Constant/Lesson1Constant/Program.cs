using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            //constant declaration 
            double r;
            Console.WriteLine("Enter Radious:");
            r=Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi*r*r;
            Console.WriteLine("Radious:{0}, Area: {1}",r,areaCircle);
            Console.ReadLine();
        }
    }
}
