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
            Console.ReadLine();
        }
    }
}
