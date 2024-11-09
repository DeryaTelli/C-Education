using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2Question
{
    internal class BookInfo
    {
        //kutuphaneden alinan kitap ile iligili islemler menu yardimi ile yapilmaktadir
        //get set metotlari yazara soruyu cozunuz 
        // kullanici "1" bastiginda kitabin adi yazari ve basim yili bilgisi goruntulenecektir ve
        // bu alanlar private olacak tanimlanacak 
        private string bookName="Computer Scients";
        private string autherName="Derya Telli";
        private int year=2022;

        public string BookName
        {
            get { return bookName; }
            set { bookName=value; }
        }

        public string AutherName
        {
            get { return autherName; }
            set { autherName=value; }
        }
        public int Year
        {
            get { return year; }
            set { year=value; }
        }

        // kullanici "2" ye bastiginda kisnin belirttigi gun sayisi 1-7 gun arasinda ise 
        // gun basina 5tl 7-15 gun arasindaysa 10 tk gunluk gecikme bedeli olacak sekilde 
        // punish calculate fonsiyonu ile hesaplayacaktir ceze bedeli ekranda goruntulenecektir 

        public void BookInfoText()
        {
            Console.WriteLine("Book name: " +bookName+ " Auther name: "+autherName+ "Year: "+year); 
        }
        public void PunishCalculate(int Pday)
        {
            int result;
            if (Pday>1 && Pday<7)
            {
                result=Pday*5;
                Console.WriteLine("Ceza:"+result);
            }
            else if (Pday>7 && Pday<15) 
            {
               result= Pday*10;
                Console.WriteLine("Ceza:"+result);
            }
        }
    }
}
