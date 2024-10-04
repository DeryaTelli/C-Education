using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1GlobalVariable
{
    internal class Program
    {
        class Bread
         //bread classi icin nesne olusturulmak zorundadir 
        {
            public int counter;
        }
        static class Butter
          //static classinin icindeki degiskenleride static olmali ve nesne olusturulmadan icerige erisim saglanabilir 
        {
            public static int counter;

        }
        static void Main(string[] args)
        {
            Bread b = new Bread();
            b.counter=5;
            Console.WriteLine("Bread: "+b.counter);

            Butter.counter=7;
            Console.WriteLine("Butter of counter: "+Butter.counter);
            Console.ReadLine();
        }
    }
}
