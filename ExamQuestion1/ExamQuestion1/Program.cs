using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQuestion1
{
    internal class Program
    {
        public static int SpaceCount(string text )
        {
            int space = 0;
            string text1;
            for (int i=0; i<text.Length; i++)
            {
                text1=text.Substring(i, 1);
                if (text1==" ")
                {
                    space++;
                }
            }
            return space;

        }
        static void Main(string[] args)
        {

            //klavyeden girilen bir cumle icerisindeki bosluklarin sayisini spacecount fonksiyonu kullanarak hesaplayip bosluk
            //sayisini ana fonksiton icersinde yazdiran program yaziniz
            Console.Write("Plese enter the sentences: ");
            string text = Console.ReadLine();
           
            Console.WriteLine("Text: "+text+ "Sentences contain spaces "+ SpaceCount(text));
            Console.ReadLine();
        }
    }
}
