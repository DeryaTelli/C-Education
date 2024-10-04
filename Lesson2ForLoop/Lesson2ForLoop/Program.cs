using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Number: "+i);
            }
            //////////////////////////////////////

            for (int j=1; j<=5; j++)
            {
                if (j==4)
                {
                    continue; // deger 4 olunca onu yazdirmiyacak digr donguye gececektir 
                }
                Console.WriteLine("end of loop number "+j+ "for j");
            }
            ///////////////////////////////////////
            
            for(int a=0; a<2; a++)
            {
                for(int b=0; b<4; b++)
                {
                    Console.WriteLine("Value of a: "+a+" b: "+b);
                }
            }

            //////////////////////////////////////
            


            Console.ReadLine();


        }
    }
}
