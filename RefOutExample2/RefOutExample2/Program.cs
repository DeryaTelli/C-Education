using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutExample2
{
    internal class Program
    {
        static void CalculateSquareAndDouble(ref int number, out int square)
        {
            square = number *number; // karesini hesapla out parametersi 
            number *=2; // ciftini hesapla ref parametresi ile 
        }
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Real value: "+value);

            int squareResult; 
            CalculateSquareAndDouble(ref value , out squareResult);
            Console.WriteLine("iki katina cikarrilmis deger: "+value);
            Console.WriteLine("Kare degeri: " +squareResult);
        }
    }
}
