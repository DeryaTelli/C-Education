using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4ClassPolymorphism
{
    class Animal // base class (parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("the animal makes a sound");
        }
    }
    class Pig : Animal //derived calss (turetilmis class child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal
    {
        public override void animalSound() 
        {
            Console.WriteLine("The dog says: Bow bow");
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal= new Animal(); // create a animal object 
            Animal mypig= new Pig();// create a pig object 
            Animal myDog= new Dog();//create a dog object 

            myAnimal.animalSound();
            myDog.animalSound();
            mypig.animalSound();
            Console.ReadLine();
        }
    }
}
