using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list =new ArrayList(); // yada boyle tanimlama yapabilirsin var list = new ArrayList();
            list.Add(1);
            list.Add("derya");
            list.Add(4.5);
            list.Add(true);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            var list2 = new ArrayList()
            {
                2, "Steve", " " , true , 4.5 , null
            };
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }

            var list3 = new ArrayList();
            var list4 = new ArrayList()
            {
                1, "Bill" , true , 4.5 , null
            };
            int[] arr = { 100, 200, 300, 400 };

            Queue myq = new Queue(); //C#'ta bir FIFO (First In, First Out - İlk Giren İlk Çıkar) veri yapısını temsil eder.
            myq.Enqueue("Hello");
            myq.Enqueue("World"); // queue ye eleman ekleme 

            list3.AddRange(list4);// add arrayliste in arraylist 
            list3.AddRange(arr);// add array in arraylist 
            list3.AddRange(myq);// add queue in arraylist 
            foreach(var item in list3)
            {
                Console.WriteLine(item);

            }

            var arlist = new ArrayList()
            {
                1,"bill",300,4.5
            };

            //index kullanarak icerige erismem 
            int firstElement = (int)arlist[0]; // return 1
            string secondElement=(string)arlist[1]; // returns "Bill"
            // int secondElement=(int)arlist[1] hata verecektir can not cover string to int 

            var firstelement1=arlist[0]; //return 1 
            var secondelement1=arlist[1];//return bill 

            //update element 
            arlist[0]="Steve ";
            arlist[1]=100;


            ArrayList list5 = new ArrayList()
            {
                1,2 ,"derya", true
            };
            list5.Insert(4, "deli");
            list5.InsertRange(3, arlist);
            foreach(var list6 in list5)
            {
                Console.WriteLine (list6);
            }

            //remove 
            list5.Remove("deli");
            list5.RemoveAt(5);


            Console.ReadLine();

        }
    }
}
