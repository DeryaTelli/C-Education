using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden gun ay yil seklinde 3 kisnin dogum tarihi dt1 , dt2, dt3 degiskenlerinde 
            //tutulacaktir bu tarih degiskenlerinin yil degerleri 
            //Birthday_list isimli ArrayList icerisinde eklenerek liste icersindeki kisilerin yasini 
            //hesaplayarak en kucuk yasi ekrana yazdiran programi yazdirin 
            //arraylist ve datetime hazir methodlari kullaniniz 

            Console.WriteLine("Enter your birthday  : ");
            DateTime dt1=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your birthday: ");
            DateTime dt2=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your birthday: ");
            DateTime dt3= Convert.ToDateTime(Console.ReadLine());
            int[] age = { (DateTime.Now.Year-dt1.Year), (DateTime.Now.Year-dt2.Year), (DateTime.Now.Year-dt3.Year) }; 
            ArrayList birthday_list = new ArrayList() ;
            foreach(int list  in age)
            {
                birthday_list.Add(list);
            }
            birthday_list.Sort();
            Console.WriteLine("the less age: "+birthday_list[0]);
            Console.ReadLine();

        }
    }
}
