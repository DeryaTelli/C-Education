using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExapmle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 10, 20, 30, 50, 2 };
            int sum = 0;
            foreach (int i in list ) 
            { 
                sum += i;
            }
            double average = sum / list.Count;
            Console.WriteLine("Average: "+average);
            Console.ReadLine();

        }
    }
}
