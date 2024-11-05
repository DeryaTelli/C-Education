using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodExm5
{
    internal class Program
    {
        public class Employee
        {
            public string name;
            public double salary;

            public Employee(string name)
            {
                this.name = name;
                salary = 0.0;
            }
            public Employee(string name, double salary)
            {
                this.name = name;
                this.salary = salary;
            }
            public void EmployeInfo()
            {
                Console.WriteLine("Name: "+name+ " Salary: "+salary);
                
            }
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Deraa");
            e1.EmployeInfo();
            Employee e2 = new Employee("Defne", 10000);
            e2.EmployeInfo();
            Console.ReadLine();
        }
    }
}
