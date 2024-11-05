using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodexm2
{
    internal class Program
    {
        public class Student
        {
            public string Name{get; set;}
            public int Age { get; set;}
            public int StNum { get; set; }

            public Student()
            {
                Name="Bilinmiyor";
                Age=0;
                StNum = 0;
            }
            public Student(string name , int age)
            {
                Name=name;
                Age=age;
                StNum=0;
            }
            public Student(string name , int age ,int stNum)
            {
                Name=name;
                Age=age;
                StNum=stNum;
            }
            public void StudentInfo()
            {
                Console.WriteLine("Name: "+Name+" Age: "+Age+" Student Number: "+StNum);
            }
           
                

        }
        static void Main(string[] args)
        {
            Student s1=new Student();
            s1.StudentInfo();
            Student s2=new Student("Derya",22);
            s2.StudentInfo();
            Student s3 = new Student("Derya Telli", 20, 26112);
            s3.StudentInfo();
            Console.ReadLine();

        }
    }
}
