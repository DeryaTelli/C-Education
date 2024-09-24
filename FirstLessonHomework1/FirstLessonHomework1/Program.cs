using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLessonHomework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number>45)
            {
                Console.WriteLine("Number is big than 45 ");
            }
            else if (number<45)
            {
                Console.WriteLine("Number is small than 45");

            }
            else
            {
                Console.WriteLine("Number is equal 45");
            }
            Console.ReadLine();
        }
    }
}
