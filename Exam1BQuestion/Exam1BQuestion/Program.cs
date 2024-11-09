using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1BQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen sayiya kadar olan tek sayilari ve
            //toplamini ekrana yazan programi yaziniz

            Console.WriteLine("Enter one number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < number; i++)
            {
                // Console.WriteLine(i);
                if (i %2 != 0)
                {
                    Console.WriteLine("Odd number: " +i);
                    result+=i;
                     
                }
            }
            Console.WriteLine("Odd total: "+result);
            Console.ReadLine();
        
        }
    }
}
