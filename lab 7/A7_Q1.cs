using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Q1
{
    public struct student
    {
        private int _roll;
        private string _name;
        private string _gen;
        private double _mob;

        public string Name 
        {
            get { return _name; }
            set { _name = value; } 
        }

        public int Roll
        {
            get { return this._roll; }
            set { this._roll = value; }
        }

        public string Gender
        {
            get { return this._gen; }
            set { this._gen = value; }
        }

        public double Mob
        {
            get { return this._mob; }
            set { this._mob = value; }
        }

        public student (int roll, string name, string gen, int mob)
        {
            this._roll= roll;
            this._name = name;
            this._gen= gen;
            this._mob= mob;
        }

        public void printDetails()
        {
            Console.WriteLine("\nDetail of studet\n");
            Console.WriteLine(".....................................\n");
            Console.WriteLine($"Roll No    : {this._roll}");
            Console.WriteLine($"Name       : {this._name}");
            Console.WriteLine($"Gender     : {this._gen}");
            Console.WriteLine($"Mobile No  : {this._mob}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            student s=new student();
            Console.Write("Enter the Roll no : ");
            s.Roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name : ");
            s.Name = (Console.ReadLine());
            Console.Write("Enter the Gender : ");
            s.Gender = (Console.ReadLine());
            Console.Write("Enter the Mobile no : ");
            s.Mob = Convert.ToDouble(Console.ReadLine());
            s.printDetails();
            Console.ReadLine();

        }
    }
}
