using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodExm6
{
    internal class Program
    {  
        public class Product
        {
            public string name;
            public double price;
            public double discount;
            public static double vat = 1.8;

            public Product(string name , double price, double discount)
            {
                 this.name = name;
                this.price = price;
                this.discount = discount;

            }
            public double CalculateFinalPrice()
            {
                return (price - discount)*(1+vat);
            }
            public void ProductInfo()
            {
                Console.WriteLine("Name: "+name+ " Price: "+price+ " Discount: " +discount);
            }



        }
        static void Main(string[] args)
        {
            Product p1 = new Product("Cips", 45.5, 5);
            double price=p1.CalculateFinalPrice();
            p1.ProductInfo();
            Console.WriteLine("Total price: "+price);
            Console.ReadLine();
        }
    }
}
