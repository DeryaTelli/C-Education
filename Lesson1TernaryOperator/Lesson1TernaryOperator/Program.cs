using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ternary operator 

            int x = 20, y = 10;
            var result = x>y ?  "x is greater than y" : "x is less than y";
            // ? isaretinden sonraki tirnak icindeki ifade verilen (x>y) nin dogru oldugunu soyler yani ilk kosuldur digeri ise yanlis olan kosuldur 

            //switch case yapisi 
            Console.Write("Enter number:");
            int b = Convert.ToInt32((Console.ReadLine()));

            switch (b)
            {
                case 5:
                    Console.WriteLine("Value of b is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of b is 10");
                    break;
                case 20:
                    Console.WriteLine("Value of b is 20");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.ReadLine();
            


        }
    }
}
