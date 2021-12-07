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
            int[,] arr = new int[3, 3]
            {
                {10, 40, 50 },
                {60, 20, 70 },
                {80, 90, 30 }
            };
            for (int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0; j<arr.GetLength(1);j++)
                {
                    if(i==j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
