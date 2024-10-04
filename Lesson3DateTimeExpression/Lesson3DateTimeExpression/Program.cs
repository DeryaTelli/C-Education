using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3DateTimeExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt); //1.01.0001 00:00:00
            

            //year , month , day ,hour , min , seconds ,UTC timezone 
            DateTime dt3 = new DateTime(2019, 12 ,31,5,10,20,DateTimeKind.Utc);
            Console.WriteLine(dt3);

            DateTime dt4 = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt4.Add(ts); // gune saat eklemesi yaptik 
            Console.WriteLine(newDate);//1.01.2016 01.20.55 

            // operatorlerle herhangi bir isleme yapilabilir datetime ve timespana 
            Console.ReadLine();
        }
    }
}
