using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_Q3
{
    class Program
    {
        public static double pay(double p, double r, double t)
        {
            double si = (p * r * t) / 100;
            return si;
        }
        static void Main(string[] args)
        {

            Console.Write("Enter principle (amount) : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time : ");
            double t = Convert.ToDouble(Console.ReadLine());

            double si = Program.pay(p, r, t);
            Console.WriteLine($"Simple Intrest : {si}");
            double amt = p + si;
            Console.WriteLine($"Total amount to be pay : {amt}");
            Console.ReadKey();
        }
    }
}
