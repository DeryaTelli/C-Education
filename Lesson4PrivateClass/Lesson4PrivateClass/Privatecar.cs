using System;

namespace Lesson4PrivateClass
{
    class Person
    {
        private string name;
        private int age=19;
        private string surName;

        // get set tanimlama 1 
        public string SurName // deger verilmeyen privatelar icin en mantikli tanimlama 
        {
            get; set;
        }
        // get set tanimlama 2 
        public int Age // private degerin 
        {
            get { return age; } 
            set { age = value; }
            

        }

        public string Name
        {
            get { return name; } // private degeri goruntulemek icin kullanilir
            set { name = value; } //private degeri degistirmek icin kullanilir 
        }

    }
}