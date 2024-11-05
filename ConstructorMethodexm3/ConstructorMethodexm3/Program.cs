using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodexm3
{
    internal class Program
    {
        public class Rectangle
        {
            public double Width; 
            public double Height;

            public Rectangle(double width, double height)
            {
               Width=width;
               Height=height;
            }
            public double CalculateArea()
            {
                return (Width*Height);
            }
            public double CalculatePerimeter()
            {
                return 2*(Width+Height);
            }
           

        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 3);
            double area=r.CalculateArea();
            Console.WriteLine("Area: " +area);
            double perimeter=r.CalculatePerimeter();
            Console.WriteLine("Perimeter: "+perimeter);
            Console.ReadLine();
        }
    }
}
