using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "Derya", "Zilan", "Irem", "Munto", "Mihri" };
            ArrayList list = new ArrayList();
            foreach (string names in dizi)
            { 
                list.Add(names);
            }
            foreach (string values in list) 
            { 
                Console.WriteLine(values);
            }
            Console.WriteLine("\nRemove some values");
            list.Remove("Derya");
            list.RemoveAt(2);
            foreach (string vals in list) 
            { 
                Console.WriteLine(vals);
            }
            Console.ReadLine();
        }
    }
}
