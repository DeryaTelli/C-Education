using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3Question
{
    internal class Program
    {

        public class Person
        {
            string Name;
            public Person(string name)
            {
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            // ahmet , ayse , elif , mehmet , kerem  isimlerini iceren person_list isimli
            // arraylist yapisini gerekli kutuphaneyi ekleyerek tanimlayiniz
            //Kullanicinin girdigi ismin listede olup olmadigini person class isimli dosya icerisinde tanimladiginiz 
            //Constructor Methodu kullanarak sorgulayiniz aranan isim liste icerisinde varsa bulundu yazdirip Person_list
            //isimli listeden siliniz yoksa liste icerisinde bulunmadi bilgisini ekrana yazdiriniz 
            //verilen listede mehmet isimli kisiyi listeden silerek listeyi tersten ekrana yazdiriniz 

            string[] dizi = { "ahmet", "ayse", "mehmet", "kerem" };
            ArrayList person_list= new ArrayList();
            foreach (string list in dizi)
            {
                person_list.Add(list);
            }
            Console.WriteLine("Enter name please:");
            string name = Console.ReadLine();
            if (person_list.Contains(name))
            {
                Console.WriteLine("Name found!!");
                person_list.Remove(name);
                Console.WriteLine("Delete:"+name);

            }
            else
            {
                Console.WriteLine("Name didn't find ");
            }

            person_list.Remove("mehmet");
            Console.WriteLine("Mehmet's name delete");
            person_list.Reverse();
            foreach (string reverselist in person_list) 
            {
                Console.WriteLine("Reverse list:"+reverselist);
            }
            Console.ReadLine();

        }
    }
}
