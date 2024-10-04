using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2MlutiArray
{
    internal class Program
    {
        double getAverage(int[] arr)
        {

            double avg;
            int sum = 0;
            for (int a = 0; a<arr.Length; a++)
            {
                sum +=arr[a];

            }
            avg=(double)sum/arr.Length;
            return avg;
        }
        static void Main(string[] args)
        {
            Program app = new Program();
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;
            avg=app.getAverage(balance);
            Console.WriteLine("Average value is : {0}", avg);
            Console.ReadLine();
        }
    }
}
