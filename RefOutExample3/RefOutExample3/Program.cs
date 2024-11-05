using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutExample3
{
    internal class Program
    {
        static void FindMinMax(int[] numbers, out int min ,out int max)
        {

            min = numbers[0];
            max = numbers[0];
            foreach(int num in numbers)
            {
                if (num<min) min=num;
                if (num>max) max=num;
            }
        }

        static void ResetToZero(ref int number)
        {
            number=0;
        }
        static void Main(string[] args)
        {
            int[] values = { 2, 3, 1, 9, 4 };
            FindMinMax(values, out int minValue, out int maxValue);
            Console.WriteLine("min value: "+minValue);
            Console.WriteLine("max value: "+maxValue);


            int value = 100;
            Console.WriteLine("Real value: "+value);
            ResetToZero(ref value);
            Console.WriteLine("Sifirlanmis Deger: "+value);
            
            Console.ReadLine();
        }
    }
}
