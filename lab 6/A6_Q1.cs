using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_Q1
{
    class Program
    {
        public static int fact(int num)
        {
            int result = 1;
            for(int i=1;i<=num;i++)
            {
                result = result * i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = Program.fact(num);
            Console.WriteLine($"Factorial of {num} is : {res}");
            Console.ReadKey();
        }
    }
}
