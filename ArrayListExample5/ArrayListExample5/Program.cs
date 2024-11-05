using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { "Dera", "Ela", "Ali" };
            list.Reverse(); // ali ela dera diye yazacaktir 
            foreach (string s in list) 
            {
                Console.WriteLine(s);
            }
            

            ArrayList list2 = new ArrayList() { "Deniz", "Elif", "Leyla", "Buse" };
            string isim ="Esma";
            if (list2.Contains(isim))
            {
                Console.WriteLine("it found");
            }
            else
            {
                Console.WriteLine("it doesn't found ");
            }

            Console.ReadLine();
        }
    }
}
