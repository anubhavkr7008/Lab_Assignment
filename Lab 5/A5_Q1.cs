using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int[] arr = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter the number to be add : ");
                arr[i] =Convert.ToInt32(Console.ReadLine()); 
            }
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
