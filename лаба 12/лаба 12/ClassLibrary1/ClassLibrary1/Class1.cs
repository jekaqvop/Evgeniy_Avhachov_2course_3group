using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        int zp = 500;
        string name;
        public string Name { get => name; set { name = value; } }
        public Student(string name)
        {
            Name = name;
        }

        public int Zp
        {
            get => zp;
            set
            {
                zp = value;
            }
        }

        public void AddZp(int add)
        {
            Console.WriteLine("премия " + Name);
            Zp += add;
        }

        public void Minus()
        {
            Console.WriteLine("Штраф " + Name);
            Zp -= 100;
        }


    }
    public class Tokar
    {

        int zp = 1000;

        string name;
        public string Name { get => name; set { name = value; } }
        public Tokar(string name)
        {
            Name = name;
        }
        public int Zp
        {
            get => zp;
            set
            {
                zp = value;
            }
        }

        public void AddZp(int add)
        {
            Console.WriteLine("премия " + Name);
            Zp += add;
        }

        public void Minus()
        {
            Console.WriteLine("Штраф " + Name);
            Zp -= 100;
        }
    }
}

