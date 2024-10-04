using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Enum
{
    internal class Program
    {
        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday , Friday, Saturday, Sunday 
        }
        enum Days
        {
            sun, mon , tue , wed ,thu ,fri ,sat 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday); // enum classindaki weekdaysdan gun isimlerine ulasiyorum 

            int day= (int)WeekDays.Friday; // enum to int conversion 
            Console.WriteLine(day);

            var wd = (WeekDays)5; // int ro enum conversion 
            Console.WriteLine(wd);

            int weekdaystart = (int)Days.mon;
            int weekdayend = (int)Days.fri;
            Console.WriteLine("Monday: {0}", weekdaystart);
            Console.WriteLine("Friday: {0}", weekdayend);

            string m = Enum.GetName(typeof(WeekDays), 1);
            Console.WriteLine(m);

            Console.ReadLine();
        }
    }
}
