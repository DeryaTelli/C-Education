using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutExample
{
    internal class Program
    {
        static void DoubleValue(ref int number)
        {
            number*=2; // sayiyi iki katina cikartir 
            /*ref anahtar kelimesi, bir metoda geçirilen değeri 
             * referans olarak gönderir. 
             * Bu sayede, metod içinde yapılan değişiklikler,
             * orijinal değişkeni etkiler. ref kullanırken,
             * değişkenin metoda gönderilmeden önce bir değeri 
             * olması gerekir.*/
        }

        static void Calculate( int a , int b , out int sum , out int difference) 
        {
            sum =a+b; // toplami hesaplar 
            difference =a-b; // farki hesaplar 
            /*out anahtar kelimesi, bir metottan çıktı olarak
             * birden fazla değer döndürmek için kullanılır. 
             * out parametrelerinin metoda geçirilmeden önce
             * bir değeri olması gerekmez, ancak metod içinde
             * mutlaka bir değer atanması zorunludur.*/
        }
        static void Main(string[] args)
        {
            int value = 10;
            Console.WriteLine("orjinal deger:" +value);
            DoubleValue(ref value); // ref ile degeri gonderiyoruz
            Console.WriteLine("iki katina cikarilmis deger" +value);

            int num1 = 15;
            int num2 = 10;
            // out paremetreleri icin degiskenleri tanimliyoruz 
            int toplam;
            int fark;
            Calculate(num1, num2, out toplam, out fark); // out ile degerleri aliyoruz 
            Console.WriteLine("Toplam: "+toplam);
            Console.WriteLine("Fark: "+fark);
            Console.ReadLine();
        }
    }
}
