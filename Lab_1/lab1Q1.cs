using System;

namespace lab1_Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the radius : ");
            double r =Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r ;
            Console.WriteLine("Area of Circle : " + area);
            Console.ReadKey();
        }
    }
}
