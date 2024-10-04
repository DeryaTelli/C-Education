using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Lesson3Methods
{
    internal class Program
    {
        public int FindMax(int num1 , int num2)
        {
            int result;
            if ((num1>num2))
            {
                result=num1;
            }else
            {
               result = num2; 
            }return result;
        }
        public int factorial(int num)
        {
            int result;
            if (num==1)
            {
                return 1;
            }
            else
            {
                result= factorial(num-1)*num;
            }return result;
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            int result= n.FindMax(10, 20);
            Console.WriteLine(result);
            int factorial = n.factorial(3);
            Console.WriteLine(factorial);
            Console.ReadLine();

        }
    }
}
