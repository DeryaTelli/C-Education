using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2ArrayMultiArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("Original Array: ");

            foreach (int newlist in list)
            {
                Console.WriteLine( newlist);
            }

            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int newtemp in temp)
            {
                Console.WriteLine( newtemp);
            }


            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int newsorted in list)
            {
                Console.WriteLine(newsorted);
            }



            Console.ReadLine();
                
        }
    }
}
