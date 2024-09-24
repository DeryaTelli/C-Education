using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLessonHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //uc kenari klavyeden girilen ucgen ikiz kenar , eskenar ve cesit kenar ucgen olup olmadigini kontrol eden program 

            Console.Write("Enter first edge of  triangle: ");
            int firstEdge = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter second edge of  triangle: ");
            int secondEdge = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter third edge of  triangle: ");
            int thirdEdge = Convert.ToInt32((Console.ReadLine()));

            if (firstEdge ==secondEdge && secondEdge ==thirdEdge && firstEdge==thirdEdge)
            {
                Console.WriteLine("equilateral triangle");
            }
            else if (firstEdge==secondEdge || secondEdge==firstEdge || firstEdge==thirdEdge)
            {
                Console.WriteLine("isosceles triangle");
            }
            else
            {
                Console.WriteLine("cesitragonal triangle");
            }
            Console.ReadLine();

        }
    }
}
