using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kutuphaneden alinan kitap ile iligili islemler menu yardimi ile yapilmaktadir
            //get set metotlari yazara soruyu cozunuz 
            // kullanici "1" bastiginda kitabin adi yazari ve basim yili bilgisi goruntulenecektir ve
            // bu alanlar private olacak tanimlanacak 
            // kullanici "2" ye bastiginda kisnin belirttigi gun sayisi 1-7 gun arasinda ise 
            // gun basina 5tl 7-15 gun arasindaysa 10 tk gunluk gecikme bedeli olacak sekilde 
            // punish calculate fonsiyonu ile hesaplayacaktir ceze bedeli ekranda goruntulenecektir 
            BookInfo book = new BookInfo();
            Console.WriteLine("Enter 1 or 2 number");
            int selected = Convert.ToInt32(Console.ReadLine());
            if (selected==1)
            {
                
                book.BookInfoText();
            }
            else if (selected==2) 
            {
                Console.WriteLine(" Enter please gec kalinan gun  :");
                int pday= Convert.ToInt32(Console.ReadLine());
                book.PunishCalculate(pday);
            }
            else
            {
                Console.WriteLine("Error try again ");
            }
            Console.ReadLine();
        }


    }
}
