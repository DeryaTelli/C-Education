using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Abstraction
{

    /*Soyut sınıf (Animal): Gövdesi olmayan soyut metodlar içerebilir ve normal metodlar da tanımlayabilir. Animal sınıfında hem soyut bir metod (animalSound) hem de normal bir metod (sleep) tanımlanmıştır.
    Türetilen sınıf (Pig): Soyut sınıfın soyut metodlarını doldurmak zorundadır. Pig sınıfında animalSound() metodu doldurulmuştur ve sleep() metodunu olduğu gibi miras almıştır.
     Polimorfizm: Animal türünde bir değişken Pig nesnesini tutabilir, bu sayede soyut sınıfın metodları somut nesnelerle çağrılabilir.
    */
    abstract class Animal
    {   
        //soyutlanmis bir method olusturduk diger child classlarinda bu yapiyi aciklamamiz gerekiyor 
        public abstract void animalSound(); // abstract method does not have a body 
        //reguler method 
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
        
    }

    class Pig : Animal // derived class (inherit from animal)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal=new Pig();
            Pig myPig = new Pig();
            animal.animalSound();
            animal.sleep();
            myPig.animalSound();
            myPig.sleep();
            Console.ReadLine();
        }
    }
}
