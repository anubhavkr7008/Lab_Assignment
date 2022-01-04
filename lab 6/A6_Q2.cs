using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_Q2
{
    class Program
    {
        public static int s_intrest(int p, int r, int t)
        {
            int si;
            si = (p * r * t)/100;
            return si;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter principle (amount) : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter rate : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter time : ");
            int t = Convert.ToInt32(Console.ReadLine());

            double res = Program.s_intrest(p, r, t);
            Console.Write($"Sinmple Intrest : {res}");
            Console.ReadLine();
        }
    }
}
