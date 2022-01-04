using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_Q5
{
    class Program
    {
        public void S_intrest(int p, int r, int t, int d)
        {
            int result = 0;
            try
            {
                result = (p * r * t) / d;

            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine($"Simple Intrest : {result}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Principle (amount) : ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter rate : ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter time : ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Divided by : ");
            int d = int.Parse(Console.ReadLine());

            Program si = new Program();
            si.S_intrest(p, r, t, d);
            Console.ReadKey();

        }
    }
}
