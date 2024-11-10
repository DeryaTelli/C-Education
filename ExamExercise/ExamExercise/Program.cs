using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamExercise
{
    internal class Program
    {
        public class Student
        {
            private string name;
            private string surname;
            private int sno;
            private int mid1;
            private int mid2;
            private string scname;

            public Student(string _name, string _surname, int _sno, int _mid1, int _mid2, string _scname)
            {
                name = _name;
                surname = _surname;
                sno= _sno;
                mid1 = _mid1;
                mid2 = _mid2;
                scname=_scname;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }
            public int Sno
            {
                get { return sno; }
                set { sno = value; }
            }
            public int Mid1
            {
                get { return mid1; }
                set { mid1 = value; }
            }
            public int Mid2
            {
                get { return mid2; }
                set { mid2 = value; }
            }
            public string Scname
            {
                get { return scname; }
                set { scname = value; }
            }

            public void StudentInfo()
            {
                Console.WriteLine("Student name: "+name+" Student surname: "+surname+
                    "Student number: "+sno+ " Midterm: "+mid1+ " Final: "+mid2);
            }
            public double Average()
            {
                return Convert.ToDouble((mid1*0.3) +(mid2*0.7));
            }
            public void GetSchoolName()
            {
                Console.WriteLine("School Name: "+scname);
            }
        }

        static void Main(string[] args)
        {
            //bir tane ogrenci var ogrenci no , isim , soyisim , vize1, final okul ismi
            //adinda degisekn olacak private constructor degiskenlere deger ata 
            // ogrencegi bilgileri goster method  
            //ortalam 
            //okul ismi yazan method 
            //1 ogrenci bilgilerini goster 
            //2 ogrenci ortalamasi goster 
            //3 ogrencinin okulunu ogrn 
            //4 cikis yap 
            Console.WriteLine("1.Student Info \n 2.Student Average \n 3.School Name \n 4.Exit");
            Console.WriteLine("Select this number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Student s1 = new Student("Derya ", "Telli", 26112, 70, 60, "KBU");
            Student s2 = new Student("Rabia", "Yolcu", 256, 80, 90, "KBU");
            switch (value) {
                case 1: 
                    s1.StudentInfo();
                    s2.StudentInfo();
                    break;
                    case 2:
                    s1.Average();
                    s2.Average();
                    break;
                case 3:
                    s1.GetSchoolName();
                    s2.GetSchoolName();
                    break;
                    case 4:
                    Console.WriteLine("Exit");
                break;
                default:
                    Console.WriteLine("Wrong value ");
                    break ;

            }
            Console.ReadLine();

        }
    }
}
