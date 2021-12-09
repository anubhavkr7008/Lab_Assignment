﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Q2
{
    class Program
    {
        enum  city { Ranchi =834002 , Hazaribag =825301 , Bokaro =827013 , Bangalore =560002 , Delhi =110002 }
        static void Main(string[] args)
        {
            Console.WriteLine("City Name.\n");
            string[] cityName = Enum.GetNames(typeof(city));
            foreach (string i in cityName)
                Console.WriteLine(i);

            Console.WriteLine("\nPin Code of City\n");
            int[] n = (int[])Enum.GetValues(typeof(city));
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
