using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //initialization 
            while (i<10)
            {
                Console.WriteLine("i={0}", i);
                i++;//increment 
            }

            ////////////////////////////// 

            int a = 0;
            while (true)
            {
                Console.WriteLine("a={0}", a);
                a++;
                if (a>10)
                    break; // a 10 dan buyuk olunda donguden cik 
                //cevap 0 dan 10 kadar yazacaktir sayilari 
            }

            /////////////////////////////////    

            int b = 1;
            while (b<20)
            {
                b++;
                if ((b%2)!=0)
                {
                    continue; // eger donguye girenler tek sayi ise dongunun basina geri don 
                }
                Console.WriteLine("b="+b);
                // ciftleri yazdir 
               
            }

            ///////////////////////////////////

            int c = 0;
            while (c>=0)
            {
                Console.WriteLine("c={0}",c);
                c++;
                break; // sonsuz c yazdirir eger break koymazsam eger 
            }
            /////////////////////////////////////

            int d = 0, e = 1;
            while (d<2)
            {
                Console.WriteLine("d={0}", d);
                d++;
                while (e<2)
                {
                    Console.WriteLine("e={0}", e);
                    e++;
                }
            }

            ///////////////////////


            int w = 0;
            do
            {
                Console.WriteLine("w={0}", w);
                w++;
            } while (w<5);


            Console.ReadLine();
        }
    }
}
