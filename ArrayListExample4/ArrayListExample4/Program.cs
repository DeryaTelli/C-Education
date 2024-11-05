using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 1, 5, 6, 3, 2, 7, 4, 9, 8, 10 };
            foreach (int i in list) { 
                Console.WriteLine(i);
            }

            Console.WriteLine("Sort list: ");
            list.Sort();
            foreach (int sortedlist in list)
            {
                Console.WriteLine(sortedlist);
            }
            Console.ReadLine();
        }
    }
}
