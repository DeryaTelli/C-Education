using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLessonHomework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0-100 arasindakicift sayilari yazdirirken sayi 60 oldugundad donguden cikan program 
            for(int i=0; i<=100; i++)
            {
                if (i==61)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
