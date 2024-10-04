using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1DatatypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 100;
            double myDouble = 2.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt)); // convert int to string 
            Console.WriteLine(Convert.ToDouble(myInt)); //convert int to double 
            Console.WriteLine(Convert.ToInt32(myDouble)); //convert double to int 
            Console.WriteLine(Convert.ToString(myBool)); // convert bool to string 


            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType().ToString());

            var str = "Hello World";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());

            var d = 10.50;
            Console.WriteLine("Type of i is {0}", d.GetType().ToString());
            Console.ReadLine();

        }
    }
}
