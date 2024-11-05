using System;
using System.Collections;

namespace QuizQuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 5, 3, 4, 2, 6, 9, 8, 7, 10 };
            ArrayList list = new ArrayList();

            // Dizinin elemanlarını listeye ekle
            foreach (int temp in dizi)
            {
                list.Add(temp);
            }

            // Listeyi küçükten büyüğe sırala
            list.Sort();

            // Sıralanmış elemanları yazdır
            Console.WriteLine("Sıralanmış Elemanlar:");
            foreach (int elements in list)
            {
                Console.WriteLine("Element: " + elements);
            }

            // Çift ve tek elemanları ayırarak yazdır
            Console.WriteLine("\nÇift Elemanlar:");
            foreach (int even in list)
            {
                if (even % 2 == 0)
                {
                    Console.WriteLine(even);
                }
            }

            Console.WriteLine("\nTek Elemanlar:");
            foreach (int odd in list)
            {
                if (odd % 2 != 0)
                {
                    Console.WriteLine(odd);
                }
            }

            Console.ReadLine();
        }
    }
}
