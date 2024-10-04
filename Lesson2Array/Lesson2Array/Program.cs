using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n=new int [10]; // 10 tane degere sahip array tanimladim 
             
            for(int i=0; i<10; i++)
            {
                n[i]=i+100;
            }
            for(int j=0; j<10; j++)
            {
                Console.WriteLine("Element[{0}]={1}", j, n[j]);
            }

            /////////////////////////////////////////

            //multi array tanimlama 
            // int[,]  2 boyutlu dizi 
            // int[, ,] 3 boyutlu dizi 
            // in[, , ,] 4 boyutlu dizi

            int[,] arr2d = new int[3, 2]; // 3 satir 2 sutundan olusuyor 
            int[,] arr3d =
            {
                {1,2 },
                {2,3 },
                {3,4 }
            };

         
            
            Console.ReadLine();
        }
    }
}
