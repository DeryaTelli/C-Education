using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInformation s = new StudentInformation("222","derya", "telli",50,60,"karabuk universitesi");
            double average =s.Average();
            Console.WriteLine(s.Name);
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
