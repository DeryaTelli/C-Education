using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3RefandOut
{
    internal class Program
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp=x;
            x=y;
            y=temp;

        }
        public void getValue(out int x)
        {
            int temp = 5;
            x=temp;
        }

        public void EnterValue(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x=Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Enter the second value: ");
            y=Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            //ref:
            //Bir değişkenin referansını metot içinde kullanmak için kullanılır.
            //Değişken, metot çağrılmadan önce tanımlanmalı ve bir değerle başlatılmalıdır.
            //Metot içerisinde, değişkenin değeri değiştirilebilir ve değişiklikler çağrıldığı yere geri döner.

            Program n = new Program();
            int a = 100;
            int b = 200;
            n.swap(ref a, ref b);
            Console.WriteLine("a: "+a+" b: "+b);

            //out:
            //Bir metottan birden fazla değer döndürmek için kullanılır.
            //Değişken, metot çağrılmadan önce başlatılmak zorunda değildir. Metot içerisinde bir değer atanmalıdır.
            //out değişkenleri, metot içinde kesinlikle bir değer almalıdır.
            int c;
            n.getValue(out c);
            Console.WriteLine("c: "+ c);

            int d, e;
            n.EnterValue(out d, out e);
            Console.WriteLine("d: "+d+" e: "+e);





            Console.ReadLine();

        }
    }
}
