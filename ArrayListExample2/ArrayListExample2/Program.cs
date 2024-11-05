using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("derya");
            list.Add(1);
            list.Add(true);
            list.Add(false);
            list.Add(0.1);
            foreach (var arrayList in list) 
            {
                Console.WriteLine("Values type: "+arrayList.GetType()+"\n Values: "+arrayList);

            }
            Console.ReadLine();
        }
    }
}
