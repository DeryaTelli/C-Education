using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework
{
     class StudentInformation
    {
        private string studentNo; 
        private string name;
        private string surname;
        private int midterm1;
        private int final1;
        private string school;

        public StudentInformation(string studentNo, string name, string surname, int midterm1, int final1, string school)
        {
            this.studentNo=studentNo;
            this.name=name;
            this.surname=surname;
            this.midterm1=midterm1;
            this.final1=final1;
            this.school=school;
        }

        public string StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
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
        public int Midterm1
        {
            get { return midterm1; }
            set { midterm1 = value; }
        }
        public int Final1
        {
            get { return final1; }
            set { final1 = value; }
        }
        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public double Average()
        {
            return (0.4 *midterm1)+(0.6*final1);
        }
       
    }
}
