using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("India",91);
            ht.Add("France",33);
            ht.Add("Germany",49);
            ht.Add("Japan",81);
            ht.Add("Nepal",977);
            ht.Add("South Africa",27);
            ht.Add("Swaziland",268);

            Console.Write(ht[Console.ReadLine()]);
            Console.ReadKey();
        }
    }
}
