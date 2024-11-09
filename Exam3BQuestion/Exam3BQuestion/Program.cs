using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3BQuestion
{
    internal class Program
    {
        public class City
        {
            ArrayList city = new ArrayList() { "Ankara", "Istanbul", "Konya", "Karabuk", "Bartin" };

            public  City(string cname)
            {
                if (city.Contains(cname)==true) {
                    Console.WriteLine("Name of city found");

                }
                else
                {
                    Console.WriteLine("Name of city didn't find ");
                }
                
            }
            public void Delete_city(string cityName)
            {
                city.Remove(cityName);
                Console.WriteLine("Delete name: "+cityName);
                city.Reverse();
                foreach (string list in city)
                {
                    Console.WriteLine("Reverse city list: "+list);
                }
            }

           
               
        }
        static void Main(string[] args)
        {
            //Ankara istanbul konya karabuk bartin sehirlerini iceren city isimli bir 
            //arraylist tanimlayiniz 
            //kullanicinin girdigi sehrin listede olup olmadigini find_city fonksiyonu ile 
            //kontrol ediniz aranan isim liste icerisinde varsa bulundu liste icerisinde yoksa bulunamadi 
            //bilgisini ekrana yazdiriniz 
            //Delete_city fonksiyonu ile konya sehrini silerek listeyi tersten yazidiriniz 
            Console.WriteLine("Enter city name please: ");
            string cName = Console.ReadLine();
            City find_city=new City(cName);
            find_city.Delete_city("Konya");
            Console.ReadLine();





        }

    }
}
