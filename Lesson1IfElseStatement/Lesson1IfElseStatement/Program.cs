using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            if (a>20)
            {
                Console.WriteLine("a is greater  than 20 ");
            }
            else
            {
                Console.WriteLine("a is  less than 20 ");
            }


            int i = 20, b = 30;
            if (i>b)
            {
                Console.WriteLine("i is greater than b");

            }else if (b>i)
            {
                Console.WriteLine("b is greater than i");
            }
            else
            {
                Console.WriteLine("b is equal i");

            }
            Console.ReadLine();
        }
    }
}
